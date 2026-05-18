using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace showmembers
{
    public partial class ViewOrders : UserControl
    {
        public ViewOrders()
        {
            InitializeComponent();
            Load += OrdersView_Load;
        }

        string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";
        private void OrdersView_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            listView1.Items.Clear();

            string query = @"
            SELECT 
                O.OrderID, M.Name AS MenuItemName, OI.Quantity, (M.Price * OI.Quantity) AS ItemTotal, OI.Status FROM Orders O
            JOIN OrderItems OI ON O.OrderID = OI.OrderID
            JOIN MenuItems M ON OI.MenuItemID = M.Id WHERE OI.Status IN ('Pending', 'In Progress')
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string orderId = reader["OrderID"].ToString();
                        string itemName = reader["MenuItemName"].ToString();
                        string quantity = reader["Quantity"].ToString();
                        string itemTotal = Convert.ToDecimal(reader["ItemTotal"]).ToString("C");
                        string status = reader["Status"].ToString(); 

                        ListViewItem item = new ListViewItem(orderId);
                        item.SubItems.Add(itemName);
                        item.SubItems.Add(quantity);
                        item.SubItems.Add(itemTotal);
                        item.SubItems.Add(status);

                        listView1.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }
    }
}
