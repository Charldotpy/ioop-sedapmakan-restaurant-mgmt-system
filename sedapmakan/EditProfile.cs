using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace showmembers
{
    public partial class EditProfile : UserControl
    {
        private int userId;

        public EditProfile(int UserId)
        {
            InitializeComponent();
            userId = UserId;
            LoadProfileIntoTextBoxes();
        }

        private void LoadProfileIntoTextBoxes()
        {
            string connStr = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";
            string sql = "SELECT Name, Password, Email, Nationality, DOB, Phone FROM Users WHERE ID = @userId;";

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("No user data found for this ID.");
                        return;
                    }

                    var profile = new UserProfileModel
                    {
                        ID = userId,
                        Name = reader.GetString(0),
                        Password = reader.GetString(1),
                        Email = reader.GetString(2),
                        Nationality = reader.GetString(3),
                        DOB = reader.GetDateTime(4),
                        Phone = reader.GetString(5)
                    };

                    nameTxt.Text = profile.Name;
                    nationalityCmb.Text = profile.Nationality;
                    dobPicker.Text = profile.DOB.ToString("dd-MM-yyyy");
                    emailTxt.Text = profile.Email.Split('@')[0];
                    emailCmb.Text = "@" + profile.Email.Split('@')[1];
                    phoneTxt.Text = profile.Phone;
                    pwdTxt.Text = profile.Password;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (inputsValid())
            {
                var profile = new UserProfileModel
                {
                    ID = userId,
                    Name = nameTxt.Text.Trim(),
                    Password = pwdTxt.Text.Trim(),
                    Email = emailTxt.Text.Trim() + emailCmb.Text.Trim(),
                    Nationality = nationalityCmb.Text.Trim(),
                    DOB = DateTime.Parse(dobPicker.Text.Trim()),
                    Phone = countryCodeCmb.Text.Trim() + phoneTxt.Text.Trim()
                };

                string connStr = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";
                string updateSql = @"
                    UPDATE Users
                       SET Name = @Name,
                           Password = @Password,
                           Email = @Email,
                           Nationality = @Nationality,
                           DOB = @DOB,
                           Phone = @Phone
                     WHERE ID = @userId;";

                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand(updateSql, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", profile.ID);
                    cmd.Parameters.AddWithValue("@Name", profile.Name);
                    cmd.Parameters.AddWithValue("@Password", profile.Password);
                    cmd.Parameters.AddWithValue("@Email", profile.Email);
                    cmd.Parameters.AddWithValue("@Nationality", profile.Nationality);
                    cmd.Parameters.AddWithValue("@DOB", profile.DOB);
                    cmd.Parameters.AddWithValue("@Phone", profile.Phone);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    DialogResult confirmation = MessageBox.Show("Confirm changes and update user profile?", "Confirm Changes", MessageBoxButtons.YesNo);

                    if (confirmation == DialogResult.Yes)
                    {
                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Unable to save changes. Please ensure all required fields are filled in and your password meets all requirements.", "Error", MessageBoxButtons.OK);
            }
        }

        public void pwdGuideLbl_Click(object sender, EventArgs e)
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

        public void pwdTxt_KeyUp(object sender, KeyEventArgs e)
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

        public void updatePwdStrengthIndicator(int pwdStrength)
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

        public void pwdTxt_Leave(object sender, EventArgs e)
        {
            if (pwdTxt.Text.Contains(' '))
            {
                pwdTxt.Text = pwdTxt.Text.Replace(" ", "");
            }
        }

        private bool inputsValid()
        {
            Control[] requiredFields = [nameTxt, nationalityCmb, emailTxt, emailCmb, countryCodeCmb, phoneTxt];

            if (requiredFields.Any(c => string.IsNullOrWhiteSpace(c.Text)) || pwdStrengthPnl.BackColor == Color.Red)
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
    }
}
