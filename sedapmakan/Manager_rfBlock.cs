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
using System.Xml.Linq;

namespace Manager
{
    public partial class Manager_rfBlock : UserControl
    {
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public string DateIssued { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }

        public Manager_rfBlock(int userId, string name, int orderId, string dateIssued, string reason, string status, string statusReason)
        {
            InitializeComponent();

            UserId = userId;
            OrderId = orderId;
            DateIssued = dateIssued;
            Reason = reason;
            Status = status;
            StatusReason = statusReason;

            nameLbl.Text = name + $" (@SEDAP{userId}) -> " + $"Order #{orderId}";
            dateLbl.Text = dateIssued;
            refundLbl.Text = reason;

            if (status != "Pending")
            {
                confirmBtn.Text = "Handled";
                confirmBtn.Enabled = false;
                replyTxt.Text = (statusReason.Length > 0) ? statusReason : "No reason provided.";
                replyTxt.ReadOnly = true;

                if (status == "Approved")
                {
                    approveRb.Checked = true;
                }
                else
                {
                    rejectRb.Checked = true;
                }
                approveRb.Enabled = false;
                rejectRb.Enabled = false;
            }
        }

        private void refundLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(refundLbl.Text, "Refund Reason", MessageBoxButtons.OK);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true;";
            string query = @"UPDATE RefundRequest SET Status = @status, StatusReason = @reason WHERE UserID = @userId AND OrderID = @orderId;";

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@status", approveRb.Checked ? "Approved" : "Rejected");
                cmd.Parameters.AddWithValue("@reason", replyTxt.Text);
                cmd.Parameters.AddWithValue("@userId", UserId);
                cmd.Parameters.AddWithValue("@orderId", OrderId);

                try
                {
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Refund request status updated.", "Success", MessageBoxButtons.OK);
                        confirmBtn.Text = "Handled";
                        confirmBtn.Enabled = false;
                        replyTxt.ReadOnly = true;
                        approveRb.Enabled = false;
                        rejectRb.Enabled = false;
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
