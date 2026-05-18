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

namespace showmembers
{
    public partial class MenuUserControl : UserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }
        private void LoadMenuItem(string category)
        {
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                string query = "SELECT * FROM MenuItem WHERE Category = @Category AND Availability = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Category", category);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new MenuItemControl();
                            item.ItemName = reader["Name"].ToString();
                            item.ItemPrice = Convert.ToDecimal(reader["Price"]);
                            //item.ImagePath = reader["ImagePath"].ToString();

                            flowLayoutPanel1.Controls.Add(item);
                        }
                    }
                }
            }
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            LoadMenuItem("Main Course");
        }

    }
}
