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
    public partial class Manager_refundCtrl : UserControl
    {
        public Manager_refundCtrl()
        {
            InitializeComponent();
        }

        private void refundCtrl_Load(object sender, EventArgs e)
        {
            displayRefundRequests(false);
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userIdTxt.Text))
            {
                displayRefundRequests(false);
            }
            else
            {
                displayRefundRequests(true);
            }
        }

        private void displayRefundRequests(bool filtering)
        {
            refundPnl.Controls.Clear();
            RefundPanel panel = new RefundPanel();
            int? userId = int.TryParse(userIdTxt.Text, out int id) ? id : (int?)null;

            List<RefundRequest> refReqList = panel.allRefunds(userId);

            foreach (RefundRequest req in refReqList)
            {
                Manager_rfBlock rfCtrl = new Manager_rfBlock(req.UserId, req.UserName, req.OrderId, req.DateIssued, req.Reason, req.Status, req.StatusReason);
                refundPnl.Controls.Add(rfCtrl);
            }
        }

        private class RefundRequest
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public int OrderId { get; set; }
            public string DateIssued { get; set; }
            public string Reason { get; set; }
            public string Status { get; set; }
            public string StatusReason { get; set; }

            public RefundRequest(int userId, string userName, int orderId, string dateIssued, string reason, string status, string statusReason)
            {
                UserId = userId;
                UserName = userName;
                OrderId = orderId;
                DateIssued = dateIssued;
                Reason = reason;
                Status = status;
                StatusReason = statusReason;
            }
        }

        private class RefundPanel
        {
            private string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true";

            public List<RefundRequest> allRefunds(int? userId = null)
            {
                List<RefundRequest> refReqList = new List<RefundRequest>();
                string query = @"SELECT R.UserID, U.Name, R.OrderID, R.DateIssued, R.Message, R.Status, R.StatusReason
                               FROM RefundRequest R JOIN Users U ON R.UserID = U.ID";

                if (userId != null)
                {
                    query += " WHERE R.UserID = @userId";
                }

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

                        while (r.Read())
                        {
                            int uid = r.GetInt32(0);
                            string name = r.GetString(1);
                            int orderId = r.GetInt32(2);
                            string date = r.GetDateTime(3).ToString("yyyy-MM-dd");
                            string reason = r.GetString(4);
                            string status = r.GetString(5);
                            string statusReason = r.IsDBNull(6) ? null : r.GetString(6);

                            RefundRequest req = new RefundRequest(uid, name, orderId, date, reason, status, statusReason);
                            refReqList.Add(req);
                        }
                        r.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
                return refReqList;
            }
        }
    }
}
