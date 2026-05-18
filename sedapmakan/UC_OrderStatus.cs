using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace _123
{
    public partial class UC_OrderStatus : UserControl
    {
        private int _userId;

        public UC_OrderStatus(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadOrderStatusData();
        }

        private void LoadOrderStatusData()
        {
            try
            {
                string query = @"SELECT o.OrderID, u.Name AS CustomerName, 
                               mi.Name AS MenuItem, oi.Quantity, 
                               o.TotalPrice, o.Status, o.OrderDate
                             FROM Orders o
                             INNER JOIN Users u ON o.CustomerID = u.ID
                             INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
                             INNER JOIN MenuItems mi ON oi.MenuItemID = mi.Id
                             WHERE o.CustomerID = @UserId";

                var parameters = new[] { new SqlParameter("@UserId", _userId) };
                DataTable orderStatusData = DatabaseHelper.ExecuteQuery(query, parameters);

                listViewOrders.Items.Clear();
                foreach (DataRow row in orderStatusData.Rows)
                {
                    var item = new ListViewItem(row["OrderID"].ToString());
                    item.SubItems.Add(row["CustomerName"].ToString());
                    item.SubItems.Add(row["MenuItem"].ToString());
                    item.SubItems.Add(row["Quantity"].ToString());
                    item.SubItems.Add(string.Format("{0:0.00}", row["TotalPrice"]));
                    item.SubItems.Add(row["Status"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["OrderDate"]).ToString("g"));
                    listViewOrders.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load order status data: {ex.Message}", "Error");
            }
        }

        // Public method for refreshing
        public void RefreshOrderStatus()
        {
            LoadOrderStatusData();
        }
    }
}