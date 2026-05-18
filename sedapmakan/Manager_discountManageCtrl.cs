using System;
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
    public partial class Manager_discountManageCtrl : UserControl
    {
        public Manager_discountManageCtrl()
        {
            InitializeComponent();
        }

        private void discountManageCtrl_Load(object sender, EventArgs e)
        {
            discountPnl.Controls.Clear();
            displayDiscounts();
        }

        private void displayDiscounts()
        {
            DiscountPanel panel = new DiscountPanel();
            List<Discount> discList = panel.allDiscounts();

            foreach (Discount dc in discList)
            {
                Manager_discBlock discCtrl = new Manager_discBlock(dc.DiscountId, dc.DiscountType, dc.Code, dc.Value, dc.Availability);
                discountPnl.Controls.Add(discCtrl);
            }
        }

        private class Discount
        {
            public int DiscountId { get; set; }
            public string DiscountType { get; set; }
            public string Code { get; set; }
            public decimal Value { get; set; }
            public int Availability { get; set; }

            public Discount(int discountId, string discountType, string code, decimal value, int availability)
            {
                DiscountId = discountId;
                DiscountType = discountType;
                Code = code;
                Value = value;
                Availability = availability;
            }
        }

        private class DiscountPanel
        {
            private string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true";

            public List<Discount> allDiscounts()
            {
                List<Discount> discList = new List<Discount>();
                string query = "SELECT * FROM Discount";

                using (SqlConnection conn = new SqlConnection(connectionStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader r = cmd.ExecuteReader();

                        while (r.Read())
                        {
                            int discountId = r.GetInt32(0);
                            string discountType = r.GetString(1);
                            string code = r.IsDBNull(2) ? null : r.GetString(2);
                            decimal value = r.GetDecimal(3);
                            int availability = r.GetInt32(4);

                            Discount disc = new Discount(discountId, discountType, code, value, availability);
                            discList.Add(disc);
                        }

                        r.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
                return discList;
            }
        }
    }
}
