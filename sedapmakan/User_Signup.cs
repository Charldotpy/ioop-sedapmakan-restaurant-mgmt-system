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

namespace showmembers
{
    public partial class User_Signup : UserControl
    {
        public User_Signup()
        {
            InitializeComponent();
        }

        private void pwdGuideLbl_Click(object sender, EventArgs e)
        {
            string message = """
                1. Password must be at least 8 characters long.
                2. Password must contain both lowercase and uppercase letters.
                3. Password must contain digits.
                4. Password must contain symbols.
                5. Password cannot contain spaces.
                """;
            MessageBox.Show(message, "Password Rules", MessageBoxButtons.OK);
        }

        private void pwdTxt_KeyUp(object sender, KeyEventArgs e)
        {
            int pwdStrength = 0;

            if (pwdTxt.Text.Length >= 8)
            {
                pwdStrength++;
            }
            if (pwdTxt.Text.Any(char.IsLower) && pwdTxt.Text.Any(char.IsUpper))
            {
                pwdStrength++;
            }
            if (pwdTxt.Text.Any(char.IsDigit))
            {
                pwdStrength++;
            }
            if (pwdTxt.Text.Any(c => char.IsSymbol(c) || char.IsPunctuation(c)))
            {
                pwdStrength++;
            }
            updatePwdStrengthIndicator(pwdStrength);
        }

        private void updatePwdStrengthIndicator(int pwdStrength)
        {
            if (pwdTxt.Text.Length < 8 || pwdStrength < 3)
            {
                pwdStrengthPnl.BackColor = Color.Red;
            }
            else if (pwdStrength == 3)
            {
                pwdStrengthPnl.BackColor = Color.Gold;
            }
            else if (pwdStrength > 3)
            {
                pwdStrengthPnl.BackColor = Color.LawnGreen;
            }
        }

        private void pwdTxt_Leave(object sender, EventArgs e)
        {
            if (pwdTxt.Text.Contains(' '))
            {
                pwdTxt.Text = pwdTxt.Text.Replace(" ", "");
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (inputsValid())
            {
                DialogResult confirmation = MessageBox.Show("Confirm create a new account with the following details?", "Confirm Sign Up", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    createNewAccount();
                    MessageBox.Show("New account successfully created. Welcome!", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Unable to sign up. Please ensure all required fields are filled in and your password meets all requirements.", "Error", MessageBoxButtons.OK);
            }
        }

        private bool inputsValid()
        {
            Control[] requiredFields = [nameTxt, nationalityCmb, emailTxt, emailCmb, countryCodeCmb, phoneTxt];
            RadioButton[] selectableRoles = [customerRb, chefRb, managerRb, adminRb];

            if (requiredFields.Any(c => string.IsNullOrWhiteSpace(c.Text)) || !selectableRoles.Any(c => c.Checked) || pwdStrengthPnl.BackColor == Color.Red)
            {
                return false;
            }
            else if (pwdStrengthPnl.BackColor == Color.Gold)
            {
                DialogResult confirmation = MessageBox.Show("Your password could be stronger. Stick with this password?", "Confirm Password", MessageBoxButtons.YesNo);
                return (confirmation == DialogResult.Yes);
            }
            return true;
        }

        private void createNewAccount()
        {
            string connectionStr = "data source=localhost;initial catalog=SedapMakanDatabase;trusted_connection=true;";
            string query = @"INSERT INTO Users (Name, Role, Nationality, DOB, Email, Phone, Password) VALUES (@name, @role, @nationality, @dob, @email, @phone, @password)";
            string role = "";

            foreach (Control c in signUpPnl.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    role = rb.Text;
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@nationality", nationalityCmb.Text);
                cmd.Parameters.AddWithValue("@dob", dobPicker.Text);
                cmd.Parameters.AddWithValue("@email", emailTxt.Text + emailCmb.Text);
                cmd.Parameters.AddWithValue("@phone", countryCodeCmb.Text + phoneTxt.Text);
                cmd.Parameters.AddWithValue("@password", pwdTxt.Text);

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
    }
}
