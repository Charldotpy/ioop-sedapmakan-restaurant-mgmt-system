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

namespace Manager
{
    public partial class Manager_feedbackCtrl : UserControl
    {
        public Manager_feedbackCtrl()
        {
            InitializeComponent();
        }

        private void feedbackCtrl_Load(object sender, EventArgs e)
        {
            displayFeedback();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            displayFeedback();
        }

        private void displayFeedback()
        {
            feedbackPnl.Controls.Clear();
            // attempt to convert the entered user Id into an integer, stores null if attempt fail
            int? userId = int.TryParse(userIdTxt.Text, out int id) ? id : (int?)null;

            List<Feedback> fbList = Feedback.allFeedbacks(userId);

            // for every feedback that exists, create a panel which stores relevant info and instantiate it to the main user control
            foreach (Feedback fb in fbList)
            {
                Manager_fbBlock fbCtrl = new Manager_fbBlock(fb.FeedbackId, fb.UserId, fb.UserName, fb.Date, fb.Message, fb.Reply);
                feedbackPnl.Controls.Add(fbCtrl);
            }
        }

        private class Feedback
        {
            public int FeedbackId { get; set; }
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Date { get; set; }
            public string Message { get; set; }
            public string Reply { get; set; }

            public Feedback(int feedbackId, int userId, string userName, string date, string msg, string reply)
            {
                FeedbackId = feedbackId;
                UserId = userId;
                UserName = userName;
                Date = date;
                Message = msg;
                Reply = reply;
            }

            public static List<Feedback> allFeedbacks(int? userId = null)
            {
                ;
                List<Feedback> fbList = new List<Feedback>();
                string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true";

                string query = @"SELECT F.FeedbackID, F.CustomerID, U.Name, F.SubmittedDate, F.Message, F.Reply 
                                FROM Feedback F JOIN Users U ON F.CustomerID = U.ID JOIN Orders O ON U.ID = O.CustomerID";

                if (userId != null)
                {
                    // if feedback is being filtered
                    query += " WHERE F.CustomerID = @userId";
                }
                query += " GROUP BY F.FeedbackID, F.CustomerID, U.Name, F.SubmittedDate, F.Message, F.Reply";

                using (SqlConnection conn = new SqlConnection(connectionStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (userId != null)
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                    }

                    try
                    {
                        conn.Open();
                        SqlDataReader r = cmd.ExecuteReader();

                        // for every feedback that exists, fill in the data and append it to a list
                        while (r.Read())
                        {
                            int fbId = r.GetInt32(0);
                            int uid = r.GetInt32(1);
                            string name = r.GetString(2);
                            string date = r.GetDateTime(3).ToString("yyyy-MM-dd");
                            string msg = r.GetString(4);
                            string? reply = r.IsDBNull(5) ? null : r.GetString(5);

                            Feedback fb = new Feedback(fbId, uid, name, date, msg, reply);
                            fbList.Add(fb);
                        }
                        r.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
                return fbList;
            }
        }
    }
}