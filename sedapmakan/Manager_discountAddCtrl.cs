using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Manager
{
    public partial class Manager_discountAddCtrl : UserControl
    {
        public string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true;";

        public Manager_discountAddCtrl()
        {
            InitializeComponent();

            registerRbEvents(typeGrp, type_CheckedChanged);
            registerRbEvents(valueGrp, value_CheckedChanged);
        }

        private void type_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            codeTxt.Clear();
            createBtn.Enabled = true;

            if (rb != null && rb.Checked)
            {
                getSelectedType(rb.TabIndex);
            }
        }

        private void value_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            valueUpDown.Minimum = rb.TabIndex;
        }

        private void registerRbEvents(GroupBox grp, EventHandler handler)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.CheckedChanged += handler;
                }
            }
        }

        private void getSelectedType(int tab)
        {
            if (tab == 0)
            {
                enableGroupbox(true, true);
            }
            else if (tab == 1)
            {
                enableGroupbox(true, false);
            }
        }

        private void enableGroupbox(bool value, bool code)
        {
            valueGrp.Enabled = value;
            codeGrp.Enabled = code;
        }

        private void codeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!percentageRb.Checked && !fixedRb.Checked || valueUpDown.Value == 0)
            {
                MessageBox.Show("Discount value not set.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                decimal value = percentageRb.Checked ? valueUpDown.Value / 100 : valueUpDown.Value;
                string query = "INSERT INTO Discount VALUES (@type, @code, @value, @availability)";

                string discountType = "";
                int tab = 0;
                foreach (Control c in typeGrp.Controls)
                {
                    if (c is RadioButton rb && rb.Checked)
                    {
                        discountType = rb.Text;
                        tab = rb.TabIndex;
                        break;
                    }
                }

                if (!errorsFound(tab))
                {
                    createNewDiscount(value, query, tab, discountType);
                }
            }
        }

        private bool errorsFound(int tab)
        {
            if (tab == 0)
            {
                if (string.IsNullOrWhiteSpace(codeTxt.Text))
                {
                    MessageBox.Show("Promotional code not set.", "Error", MessageBoxButtons.OK);
                    return true;
                }
                else if (duplicateCodeFound(codeTxt.Text))
                {
                    MessageBox.Show("Promotional code already exists.", "Error", MessageBoxButtons.OK);
                    return true;
                }
            }
            else if (tab == 1)
            {
                if (storewideDiscountExists())
                {
                    MessageBox.Show("Storewide discount already exists. Update it using the management menu.", "Error", MessageBoxButtons.OK);
                    return true;
                }
            }
            return false;
        }

        private bool duplicateCodeFound(string code)
        {
            string query = "SELECT Code FROM Discount";

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        if (!r.IsDBNull(0) && code == r.GetString(0))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        private bool storewideDiscountExists()
        {
            string query = "SELECT Type FROM Discount";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string type = r.GetString(0);
                            if (type == "Storewide")
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
        }

        private void createNewDiscount(decimal value, string query, int tab, string discountType)
        {
            string code = string.IsNullOrWhiteSpace(codeTxt.Text) ? null : codeTxt.Text;
            Discount disc = new Discount(discountType, code, value);

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = disc.CreateDiscount(conn);

                try
                {
                    conn.Open();
                    DialogResult confirmAction = MessageBox.Show("Confirm create a new discount?", "Confirm", MessageBoxButtons.YesNo);

                    if (confirmAction == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Discount created successfully! Activate it in the management menu", "Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Action aborted.", "Abort", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                }
            }
        }

        public class Discount
        {
            public string Type { get; set; }
            public string Code { get; set; }
            public decimal Value { get; set; }
            public int Availability { get; set; }

            public Discount(string type, string code, decimal value)
            {
                Type = type;
                Code = code;
                Value = value;
                Availability = 0;
            }

            public SqlCommand CreateDiscount(SqlConnection conn)
            {
                string query = "INSERT INTO Discount VALUES (@type, @code, @value, @availability)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@type", Type);
                cmd.Parameters.AddWithValue("@code", string.IsNullOrWhiteSpace(Code) ? (object)DBNull.Value : Code);
                cmd.Parameters.AddWithValue("@value", Value);
                cmd.Parameters.AddWithValue("@availability", Availability);

                return cmd;
            }
        }
    }
}