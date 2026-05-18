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

namespace Manager
{
    public partial class Manager_discBlock : UserControl
    {
        public int DiscountId { get; set; }
        public string DiscountType { get; set; }
        public string Code { get; set; }
        public decimal Value { get; set; }
        public string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true;";

        public Manager_discBlock(int discountId, string discountType, string code, decimal value, int availability)
        {
            InitializeComponent();
            registerRbEvent(valueGrp, value_CheckedChanged);

            DiscountId = discountId;
            DiscountType = discountType;
            Code = code;
            Value = value;

            discountLbl.Text = discountId.ToString();
            typeLbl.Text = discountType;
            valueUpDown.Value = value < 1 ? value * 100 : value;
            activateChk.Checked = availability == 1 ? true : false;

            if (!string.IsNullOrEmpty(code))
            {
                codeTxt.Text = code;
            }
            else
            {
                codeTxt.Text = "Not applicable.";
                codeGrp.Enabled = false;
            }

            if (value < 1)
            {
                percentageRb.Checked = true;
            }
            else
            {
                fixedRb.Checked = true;
            }
        }

        private void value_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            valueUpDown.Minimum = rb.TabIndex;
        }

        private void registerRbEvent(GroupBox grp, EventHandler handler)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.CheckedChanged += handler;
                }
            }
        }

        private void codeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void activateChk_CheckedChanged(object sender, EventArgs e)
        {
            activateChk.Text = activateChk.Checked ? "Deactivate Discount" : "Activate Discount";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Confirm update discount information?", "Confirm Update", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                decimal value = percentageRb.Checked ? valueUpDown.Value / 100 : valueUpDown.Value;
                string code = "";
                int availability = activateChk.Checked ? 1 : 0;

                if (codeTxt.Text == "Not applicable.")
                {
                    code = null;
                }
                else
                {
                    code = codeTxt.Text;
                }
                updateDiscount(value, code, availability);
            }
        }

        private void updateDiscount(decimal value, string code, int availability)
        {
            string query = @"UPDATE Discount SET Value = @value, Code = @code, Availability = @availability
                           WHERE DiscountID = @discountId";

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@availability", availability);
                cmd.Parameters.AddWithValue("@discountId", Convert.ToInt32(discountLbl.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Discount information updated successfully.", "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Delete this discount? This action cannot be undone.", "Confirm", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {                    
                    try
                    {
                        conn.Open();
                        string query = @"DELETE FROM Discount WHERE DiscountID = @discountId";


                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@discountId", Convert.ToInt32(discountLbl.Text));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}