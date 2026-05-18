using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AdminLoadingScreen
{
    internal class WalletBalCheck
    {
        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;");

        public string ID { get; set; }
        public string Name { get; set; }
        public string TopupID { get; set; }
        public string Amount { get; set; }

        public List<WalletBalCheck> ViewWallet()
        {
            List<WalletBalCheck> listdata = new List<WalletBalCheck>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    {
                        connect.Open();
                        String sql = "SELECT Users.ID, Users.Name, TopUpHistory.TopupID, TopUpHistory.Amount\r\nFROM TopUpHistory\r\nJOIN Users ON TopUpHistory.UserID = Users.ID\r\nORDER BY Users.ID;";
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                WalletBalCheck wallet = new WalletBalCheck();

                                wallet.ID = reader["ID"].ToString();
                                wallet.Name = reader["Name"].ToString();
                                wallet.TopupID = reader["TopupID"].ToString();
                                wallet.Amount = reader["Amount"].ToString();

                                listdata.Add(wallet);
                            }
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
