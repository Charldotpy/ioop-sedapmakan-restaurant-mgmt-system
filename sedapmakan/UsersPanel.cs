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

namespace AdminLoadingScreen
{
    public partial class UsersPanel : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;");
        public UsersPanel()
        {
            InitializeComponent();

            userdisplay();
        }

        public void userdisplay()
        {
            AddUserData userData = new AddUserData();

            usersgrid.DataSource = userData.AddUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if (fullname.Text == "" ||
                phone.Text == "" ||
                nationality.Text == "" ||
                dob.Text == "" ||
                role.Text == "" ||
                emailadd.Text == "" ||
                accountpassword.Text == "" ||
                ewalletball.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string insertQuery = @"INSERT INTO Users (Name, Phone, Nationality, DOB, Role, Email, Password, EWalletBalance) 
                               VALUES (@Name, @Phone, @Nationality, @DOB, @Role, @Email, @Password, @Balance)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@ID", user_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", fullname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", phone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nationality", nationality.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", dob.Value);
                    cmd.Parameters.AddWithValue("@Role", role.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", emailadd.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", accountpassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@Balance", int.Parse(ewalletball.Text.Trim()));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearfields();
                userdisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        public void clearfields()
        {
            fullname.Text = string.Empty;
            phone.Text = string.Empty;
            nationality.Text = string.Empty;
            emailadd.Text = string.Empty;
            accountpassword.Text = string.Empty;
            role.Text = string.Empty;
            ewalletball.Text = string.Empty;
            user_id.Text = "None";
        }

        private void usersgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accountpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
 
            if (user_id.Text == "None" ||
                string.IsNullOrWhiteSpace(fullname.Text) ||
                string.IsNullOrWhiteSpace(phone.Text) ||
                string.IsNullOrWhiteSpace(nationality.Text) ||
                string.IsNullOrWhiteSpace(role.Text) ||
                string.IsNullOrWhiteSpace(emailadd.Text) ||
                string.IsNullOrWhiteSpace(accountpassword.Text) ||
                string.IsNullOrWhiteSpace(ewalletball.Text))
            {
                MessageBox.Show("Please select a user from the grid and fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal balance;
            if (!decimal.TryParse(ewalletball.Text.Trim(), out balance))
            {
                MessageBox.Show("E-wallet balance must be a valid number (e.g., 100 or 10.50).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId;
            if (!int.TryParse(user_id.Text.Trim(), out userId))
            {
                MessageBox.Show("Invalid User ID for update. Please select a user from the grid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                DialogResult check = MessageBox.Show("Are you sure you want to update User: " + fullname.Text.Trim() + "?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    String updatedata = @"UPDATE Users SET
                                      Name = @Name,
                                      Phone = @Phone,
                                      Nationality = @Nationality,
                                      DOB = @DOB,
                                      Role = @Role,
                                      Email = @Email,
                                      Password = @Password,
                                      EWalletBalance = @EWalletBalance
                                  WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                    {
                        cmd.Parameters.AddWithValue("@Name", fullname.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nationality", nationality.Text.Trim());
                        cmd.Parameters.AddWithValue("@DOB", dob.Value);
                        cmd.Parameters.AddWithValue("@Role", role.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", emailadd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", accountpassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@EWalletBalance", balance);
                        cmd.Parameters.AddWithValue("@ID", userId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfields();  
                        userdisplay();   
                    }
                }
                else
                {
                    MessageBox.Show("Update Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearfields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error in updatebtn_Click: " + ex.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void usersgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = usersgrid.Rows[e.RowIndex];
                user_id.Text = row.Cells[0].Value.ToString();
                fullname.Text = row.Cells[1].Value.ToString();
                phone.Text = row.Cells[2].Value.ToString();
                nationality.Text = row.Cells[3].Value.ToString();
                dob.Text = row.Cells[4].Value.ToString();
                role.Text = row.Cells[5].Value.ToString();
                emailadd.Text = row.Cells[6].Value.ToString();
                accountpassword.Text = row.Cells[7].Value.ToString();
                ewalletball.Text = row.Cells[8].Value.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (user_id.Text == "None" || string.IsNullOrWhiteSpace(user_id.Text))
            {
                MessageBox.Show("Please select a user from the grid to delete.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userIdToDelete;
            if (!int.TryParse(user_id.Text.Trim(), out userIdToDelete))
            {
                MessageBox.Show("Invalid User ID for deletion. Please select a valid user from the grid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                DialogResult check = MessageBox.Show("Are you sure you want to delete user with ID: " + userIdToDelete + "?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    String deletedata = "DELETE FROM Users WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(deletedata, connect))
                    {
                        cmd.Parameters.AddWithValue("@ID", userIdToDelete);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfields();
                        userdisplay();
                    }
                }
                else
                {
                    MessageBox.Show("Delete Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearfields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error in deletebtn_Click: " + ex.ToString()); 
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

    }
}

