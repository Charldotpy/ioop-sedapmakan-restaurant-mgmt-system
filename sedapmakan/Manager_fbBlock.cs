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
using System.Xml.Schema;

namespace Manager
{
    public partial class Manager_fbBlock : UserControl
    {
        public int FeedbackId { get; set; }

        public Manager_fbBlock(int feedbackId, int userId, string name, string date, string message, string reply)
        {
            InitializeComponent();
            FeedbackId = feedbackId;

            nameLbl.Text = name + $" (@SEDAP{userId})";
            dateLbl.Text = date;
            feedbackLbl.Text = message;

            if (reply != null)
            {
                replyBtn.Text = "Replied";
                replyBtn.Enabled = false;
                replyTxt.Text = reply;
                replyTxt.ReadOnly = true;
            }
        }

        private void feedbackLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(feedbackLbl.Text, "Feedback", MessageBoxButtons.OK);
        }

        private void replyBtn_Click(object sender, EventArgs e)
        {
            string connectionStr = "data source=MSI;initial catalog=SedapMakanDatabase;trusted_connection=true;";
            string query = @"UPDATE Feedback SET Reply = @reply WHERE FeedbackID = @feedbackId";
            int customerId = Convert.ToInt32(nameLbl.Text.Split('#')[1].TrimEnd(')', ' '));

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@reply", replyTxt.Text);
                cmd.Parameters.AddWithValue("@feedbackId", FeedbackId);

                try
                {
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Reply has been sent.", "Success", MessageBoxButtons.OK);
                        replyBtn.Text = "Replied";
                        replyBtn.Enabled = false;
                        replyTxt.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}