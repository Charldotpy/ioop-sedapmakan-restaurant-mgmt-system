using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditMenu1 : UserControl
    {
        public EditMenu1()
        {
            InitializeComponent();
            this.Load += Restaurant_menu_Load;

        }
        private void Restaurant_menu_Load(object sender, EventArgs e)
        {
            LoadMenuItemsFromDatabase();
        }
        private void LoadMenuItemsFromDatabase()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT Id,Name, ImagePath, Price, Availability FROM MenuItems";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string imagePath = reader.GetString(2);  
                        decimal price = reader.GetDecimal(3);
                        string availability = reader.GetString(4);

                        string fullPath = Path.Combine(Application.StartupPath, imagePath);

                        var menuItem = new editingmenu
                        {
                            ItemName = name,
                            ItemPrice = price,
                            Availability = availability,
                            ItemId = id,
                        };

                        if (File.Exists(fullPath))
                        {
                            menuItem.ItemImage = Image.FromFile(fullPath);
                        }
                        else
                        {
                            continue;
                        }

                        flowLayoutPanel1.Controls.Add(menuItem);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (editingmenu item in flowLayoutPanel1.Controls)
                {
                    int id = item.ItemId;
                    string name = item.ItemName;
                    decimal price = item.ItemPrice;
                    string availability = item.Availability;

                    string updateQuery = @"UPDATE MenuItems SET Name = @Name, Price = @Price, Availability = @Availability WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {

                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Availability", availability);

                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Changes updated succesfully");
            }
        }
    }
}