using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Manager
{
    public partial class Manager_topUpCtrl : UserControl
    {
        public string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true;";

        public Manager_topUpCtrl()
        {
            InitializeComponent();
        }

        private void topUpCtrl_Load(object sender, EventArgs e)
        {
            managerRb.Checked = true;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            topUpTbl.Rows.Clear();

            string query = @"SELECT Amount, Method FROM TopUpHistory WHERE UserID = @userId";
            List<TopUpHistory> history = new List<TopUpHistory>();

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                int? userId = int.TryParse(userIdTxt.Text, out int uid) ? uid : (int?)null;
                SelectedUser user = new SelectedUser(userId);
                cmd.Parameters.AddWithValue("@userId", user.UserId != null ? user.UserId : (object)DBNull.Value);

                try
                {
                    conn.Open();

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (userExists(userId))
                        {
                            modifyButtons(selectBtn.Text);
                            int id = 0;

                            while (r.Read())
                            {
                                id++;
                                decimal amount = r.GetDecimal(0);
                                string method = r.GetString(1);

                                history.Add(new TopUpHistory(id, amount, method));
                            }

                            foreach (var topup in history)
                            {
                                topUpTbl.Rows.Add(topup.Id, topup.Amount, topup.Method);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The selected user does not exist.", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                }
            }
        }

        private bool userExists(int? userId)
        {
            string query = @"SELECT * FROM Users WHERE ID = @userId";

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@userId", userId != null ? userId : (object)DBNull.Value);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void topUpBtn_Click(object sender, EventArgs e)
        {
            decimal amountToTopup;
            bool properInput = decimal.TryParse(topUpTxt.Text, out amountToTopup); 

            if (properInput)
            {
                string query = @"UPDATE Users SET EWalletBalance += @topupAmount WHERE ID = @userId";
                SelectedUser user = new SelectedUser(Convert.ToInt32(userIdTxt.Text));

                using (SqlConnection conn = new SqlConnection(connectionStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@topupAmount", amountToTopup);
                    cmd.Parameters.AddWithValue("@userId", user.UserId);

                    try
                    {
                        conn.Open();
                        string confirmMsg = $"You are about to top-up {amountToTopup.ToString("C")} for Customer #{user.UserId}. Confirm?";
                        DialogResult confirmAction = MessageBox.Show(confirmMsg, "Confirm Top Up", MessageBoxButtons.YesNo);

                        if (confirmAction == DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            updateTopUpHistory(amountToTopup, user.UserId);
                            MessageBox.Show("Account top-up success!", "Success", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid top-up amount.", "Error", MessageBoxButtons.OK);
            }
        }

        private void updateTopUpHistory(decimal topupAmount, int? userId)
        {
            string query = @"INSERT INTO TopUpHistory VALUES (@userId, @topupAmount, @method)";

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@topupAmount", topupAmount);
                cmd.Parameters.AddWithValue("@method", managerRb.Checked ? "Manager Assistance" : "Refund");

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void modifyButtons(string btnTxt)
        {
            if (btnTxt == "Select")
            {
                selectBtn.Text = "Deselect";
                userIdTxt.ReadOnly = true;
                topUpTxt.ReadOnly = false;
                topUpBtn.Enabled = true;
            }
            else
            {
                selectBtn.Text = "Select";
                userIdTxt.ReadOnly = false;
                topUpTxt.ReadOnly = true;
                topUpBtn.Enabled = false;
            }
        }

        private class SelectedUser
        {
            public int? UserId { get; set; }
            public decimal EWalletBalance { get; set; }

            public SelectedUser(int? userId = null)
            {
                UserId = userId;
            }
        }

        private class TopUpHistory
        {
            public int Id { get; set; }
            public decimal Amount { get; set; }
            public string Method { get; set; }

            public TopUpHistory(int id, decimal amount, string method)
            {
                Id = id;
                Amount = amount;
                Method = method;
            }
        }
    }
}