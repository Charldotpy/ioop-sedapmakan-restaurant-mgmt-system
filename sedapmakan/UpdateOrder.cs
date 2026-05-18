using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace showmembers
{
    public partial class UpdateOrder : UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";
        public int ID { get; set; }
        private int _userId;

        public UpdateOrder(int ID)
        {
            InitializeComponent();
            _userId = ID;
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            listView1.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    O.OrderID, OI.MenuItemID, M.Name AS MenuItemName, OI.Quantity,
                    (M.Price * OI.Quantity) AS ItemTotal, OI.Status, OI.Remark 
                FROM Orders O
                JOIN OrderItems OI ON O.OrderID = OI.OrderID
                JOIN MenuItems M ON OI.MenuItemID = M.Id
                WHERE OI.Status IN ('Pending', 'In Progress') 
                ORDER BY O.OrderDate DESC;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["OrderID"].ToString());
                        item.SubItems.Add(reader["MenuItemName"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());
                        item.SubItems.Add(Convert.ToDecimal(reader["ItemTotal"]).ToString("F2"));
                        item.SubItems.Add(reader["Status"].ToString());
                        item.SubItems.Add(reader["Remark"].ToString());

                        item.Tag = reader["MenuItemID"].ToString();

                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void UpdateOrderItemStatus(string newStatus)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order item to update.");
                return;
            }

            var selectedItem = listView1.SelectedItems[0];
            int orderId = int.Parse(selectedItem.SubItems[0].Text);
            int menuItemId = int.Parse(selectedItem.Tag.ToString()); 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE OrderItems SET Status = @Status WHERE OrderID = @OrderID AND MenuItemID = @MenuItemID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@MenuItemID", menuItemId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order item status updated.");
                        LoadOrderItems();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
        }

        private void btnPending_Click_1(object sender, EventArgs e)
        {
            UpdateOrderItemStatus("In Progress");
        }

        private void btnInProgress_Click_1(object sender, EventArgs e)
        {
            UpdateOrderItemStatus("Pending");
        }

        private void btnCompleted_Click_1(object sender, EventArgs e)
        {
            UpdateOrderItemStatus("Completed");
        }
    }
}
