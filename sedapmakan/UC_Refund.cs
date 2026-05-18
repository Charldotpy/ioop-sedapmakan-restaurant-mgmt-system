using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _123
{
    public partial class UC_Refund : UserControl
    {
        private int _userId;

        public UC_Refund(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadOrders();
            LoadRefundData();
        }

        private void LoadOrders()
        {
            try
            {
                string query = "SELECT OrderID FROM Orders WHERE CustomerID = @CustomerID";
                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerID", _userId)
                };

                DataTable orders = DatabaseHelper.ExecuteQuery(query, parameters);
                if (orders.Rows.Count > 0)
                {
                    comboBoxOrders.DataSource = orders;
                    comboBoxOrders.DisplayMember = "OrderID";
                    comboBoxOrders.ValueMember = "OrderID";
                }
                else
                {
                    comboBoxOrders.DataSource = null;
                    //MessageBox.Show("No orders found for your account.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load orders: {ex.Message}", "Error");
            }
        }

        private void LoadRefundData()
        {
            try
            {
                string query = @"SELECT r.ID, r.OrderID, r.Message, r.Status, r.StatusReason, r.DateIssued
                                 FROM RefundRequest r
                                 WHERE r.UserID = @UserID";
                SqlParameter[] parameters = {
                    new SqlParameter("@UserID", _userId)
                };

                DataTable refundRequests = DatabaseHelper.ExecuteQuery(query, parameters);
                dataGridViewRefunds.DataSource = refundRequests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load refund data: {ex.Message}", "Error");
            }
        }

        private void buttonRequestRefund_Click(object sender, EventArgs e)
        {
            if (comboBoxOrders.SelectedItem == null)
            {
                MessageBox.Show("Please select an order to refund.", "Validation Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxReason.Text))
            {
                MessageBox.Show("Please provide a reason for the refund.", "Validation Error");
                return;
            }

            try
            {
                string query = @"INSERT INTO RefundRequest 
                                (OrderID, UserID, Message, DateIssued, Status) 
                                VALUES (@OrderID, @UserID, @Message, GETDATE(), 'Pending')";
                SqlParameter[] parameters = {
                    new SqlParameter("@OrderID", comboBoxOrders.SelectedValue),
                    new SqlParameter("@UserID", _userId),
                    new SqlParameter("@Message", textBoxReason.Text)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Refund request submitted successfully.", "Success");
                    textBoxReason.Clear();
                    LoadRefundData();
                }
                else
                {
                    MessageBox.Show("Failed to submit refund request.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
        public static class DatabaseHelper
        {
            private static readonly string connectionString = "Data Source = localhost; Initial Catalog = SedapMakanDatabase; Integrated Security = True;";

            public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }

            public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        return command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}