using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLoadingScreen
{
    internal class AddUserData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;");

        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal EWalletBalance { get; set; }

        public List<AddUserData> AddUsers()
        {
            List<AddUserData> listdata = new List<AddUserData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    String sql = "SELECT * FROM Users";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddUserData userData = new AddUserData();

                            userData.ID = reader["ID"].ToString();
                            userData.Name = reader["Name"].ToString();
                            userData.Phone = reader["Phone"].ToString();
                            userData.Nationality = reader["Nationality"].ToString();
                            userData.DOB = (DateTime)reader["DOB"];
                            userData.Role = reader["Role"].ToString();
                            userData.Email = reader["Email"].ToString();
                            userData.Password = reader["Password"].ToString();
                            userData.EWalletBalance = (decimal)reader["EWalletBalance"];

                            listdata.Add(userData);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Connecting to Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }    
            }
            return listdata;
        }
    }
}

