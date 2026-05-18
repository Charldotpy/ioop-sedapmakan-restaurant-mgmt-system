using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showmembers
{

    public partial class Restaurant_menu : UserControl
    {
        private int _userId;
        public int ID => _userId;
        public Restaurant_menu(int userId)
        {
            InitializeComponent();
            _userId = userId;
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

                string sql = @"
                    SELECT Id, Name, ImagePath, Price
                      FROM MenuItems
                     WHERE Availability = 1";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //poputing the menu item
                        var itemModel = new MenuItemModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            ImagePath = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Availability = true
                        };

                        // creating image path
                        string fullPath = Path.Combine(Application.StartupPath, itemModel.ImagePath);

                        // what to be loaded 
                        var menuItem = new MenuItem
                        {
                            ItemName = itemModel.Name,
                            ItemPrice = itemModel.Price
                        };

                        // check if image exist then load 
                        if (File.Exists(fullPath))
                            menuItem.ItemImage = Image.FromFile(fullPath);
                        else
                            continue;  // skip if image missing

                        menuItem.QuantityChanged += MenuItem_QuantityChanged;
                        flowLayoutPanelMenu.Controls.Add(menuItem);
                    }
                }
            }
        }

        private void MenuItem_QuantityChanged(object sender, EventArgs e)
        {
            var itemControl = sender as MenuItem;
            if (itemControl == null) return;

            UpdateOrderList(itemControl);
            UpdateTotals();
        }

        private void UpdateOrderList(MenuItem item)
        {
            foreach (ListViewItem lv in listViewOrders.Items)
            {
                if (lv.Text == item.ItemName)
                {
                    if (item.Quantity > 0)
                    {
                        lv.SubItems[1].Text = item.Quantity.ToString();
                        lv.SubItems[2].Text = (item.ItemPrice * item.Quantity).ToString("F2");
                    }
                    else
                    {
                        listViewOrders.Items.Remove(lv);
                    }
                    return;
                }
            }

            if (item.Quantity > 0)
            {
                var lvNew = new ListViewItem(item.ItemName);
                lvNew.SubItems.Add(item.Quantity.ToString());
                lvNew.SubItems.Add((item.ItemPrice * item.Quantity).ToString("F2"));
                listViewOrders.Items.Add(lvNew);
            }
        }

        private void UpdateTotals()
        {
            int totalQty = 0;
            decimal totalCost = 0m;

            foreach (ListViewItem lv in listViewOrders.Items)
            {
                totalQty += int.Parse(lv.SubItems[1].Text);
                totalCost += decimal.Parse(lv.SubItems[2].Text);
            }

            lblTotalItems.Text = $"Total Items: {totalQty}";
            lblTotalPrice.Text = $"Total Price: RM{totalCost:F2}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int customerId = ID;

            int totalQuantity = 0;
            decimal totalPrice = 0m;

            foreach (ListViewItem item in listViewOrders.Items)
            {
                totalQuantity += int.Parse(item.SubItems[1].Text);
                totalPrice += decimal.Parse(item.SubItems[2].Text);
            }

            if (totalQuantity == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if user got enough money
                string checkBalanceSql = "SELECT EWalletBalance FROM Users WHERE ID = @UserId";
                decimal userBalance = 0;

                using (var cmd = new SqlCommand(checkBalanceSql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", customerId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userBalance = (decimal)result;
                    }
                }

                if (userBalance < totalPrice)
                {
                    MessageBox.Show($"Insufficient funds. Your balance: RM{userBalance:F2}, Order total: RM{totalPrice:F2}",
                                   "Payment Failed");
                    return;
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string updateBalanceSql = "UPDATE Users SET EWalletBalance = EWalletBalance - @Amount WHERE ID = @UserId";
                        using (var cmd = new SqlCommand(updateBalanceSql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Amount", totalPrice);
                            cmd.Parameters.AddWithValue("@UserId", customerId);
                            cmd.ExecuteNonQuery();
                        }

                        // Insert order
                        string insertOrderSql = @"
                    INSERT INTO Orders (CustomerID, Quantity, TotalPrice, Status, OrderDate)
                    OUTPUT INSERTED.OrderID
                    VALUES (@CustomerID, @Quantity, @TotalPrice, 'Pending', GETDATE())";
                        int orderId;
                        using (var cmd = new SqlCommand(insertOrderSql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerId);
                            cmd.Parameters.AddWithValue("@Quantity", totalQuantity);
                            cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                            orderId = (int)cmd.ExecuteScalar();
                        }

                        // Insert order items
                        foreach (ListViewItem lvItem in listViewOrders.Items)
                        {
                            string itemName = lvItem.Text;
                            int quantity = int.Parse(lvItem.SubItems[1].Text);

                            string getMenuItemIdSql = "SELECT Id FROM MenuItems WHERE Name = @Name";
                            int menuItemId;
                            using (var cmd = new SqlCommand(getMenuItemIdSql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Name", itemName);
                                var result = cmd.ExecuteScalar();
                                if (result == null)
                                {
                                    MessageBox.Show($"Menu item '{itemName}' not found in database.");
                                    transaction.Rollback();
                                    return;
                                }
                                menuItemId = (int)result;
                            }

                            string insertOrderItemSql = @"
                        INSERT INTO OrderItems (OrderID, MenuItemID, Quantity, Remark)
                        VALUES (@OrderID, @MenuItemID, @Quantity, '')";
                            using (var cmd = new SqlCommand(insertOrderItemSql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@OrderID", orderId);
                                cmd.Parameters.AddWithValue("@MenuItemID", menuItemId);
                                cmd.Parameters.AddWithValue("@Quantity", quantity);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show($"Order placed successfully! RM{totalPrice:F2} has been deducted from your e-wallet.");
                        listViewOrders.Items.Clear();
                        UpdateTotals();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error placing order: {ex.Message}", "Order Failed");
                    }
                }
            }
        }
    }
    public class MenuItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public bool Availability { get; set; }

        // Parameterless constructor for object-initializer usage
        public MenuItemModel() { }

        // (Optional) full constructor
        public MenuItemModel(int id, string name, string imagePath, decimal price, bool availability)
        {
            Id = id;
            Name = name;
            ImagePath = imagePath;
            Price = price;
            Availability = availability;
        }
    }
}
