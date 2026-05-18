using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdminLoadingScreen
{
    internal class AddSalesData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;");

        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        private List<AddSalesData> GetSalesData(string sortQuery)
        {
            List<AddSalesData> list = new List<AddSalesData>();

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(sortQuery, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddSalesData data = new AddSalesData
                        {
                            OrderID = reader["OrderID"].ToString(),
                            CustomerID = reader["CustomerID"].ToString(),
                            Category = reader["Category"].ToString(),
                            Name = reader["Name"].ToString(),
                            TotalPrice = (decimal)reader["TotalPrice"],
                            OrderDate = (DateTime)reader["OrderDate"]
                        };
                        list.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            return list;
        }

        public List<AddSalesData> GetSalesByDate()
        {
            string sql = @"
                SELECT Orders.OrderDate, OrderItems.OrderID, Orders.CustomerID, MenuItems.Category, MenuItems.Name, Orders.TotalPrice
                FROM OrderItems
                JOIN MenuItems ON OrderItems.MenuItemID = MenuItems.Id
                JOIN Orders ON OrderItems.OrderID = Orders.OrderID
                JOIN Users ON Orders.CustomerID = Users.ID
                ORDER BY Orders.OrderDate DESC;";
            return GetSalesData(sql);
        }

        public List<AddSalesData> GetSalesByCategory()
        {
            string sql = @"
                SELECT MenuItems.Category, OrderItems.OrderID, Orders.CustomerID, MenuItems.Name, Orders.TotalPrice, Orders.OrderDate
                FROM OrderItems
                JOIN MenuItems ON OrderItems.MenuItemID = MenuItems.Id
                JOIN Orders ON OrderItems.OrderID = Orders.OrderID
                JOIN Users ON Orders.CustomerID = Users.ID
                ORDER BY MenuItems.Category ASC;";
            return GetSalesData(sql);
        }
    }
}
