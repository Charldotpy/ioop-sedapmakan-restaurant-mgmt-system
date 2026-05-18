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
    public partial class UC_Feedback : UserControl
    {
        private int _userId; 
        public int ID { get; set; } 
        public UC_Feedback(int ID)
        {
            InitializeComponent();
            _userId = ID;

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFeedback.Text))
            {
                try
                {
                    string query = "INSERT INTO Feedback (CustomerID, Message) VALUES (@CustomerID, @Message)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@CustomerID", _userId), 
                        new SqlParameter("@Message", textBoxFeedback.Text)
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thank you for your feedback!", "Submitted");
                        textBoxFeedback.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit feedback. Please try again.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Feedback cannot be empty.", "Validation Error");
            }
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