using _123;
using AdminLoadingScreen;
using Manager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace showmembers
{
    public partial class User_Login : UserControl
    {
        private Form1 form1;
        public event EventHandler SignUpRequested;

        public User_Login(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both user ID and password.", "Login Error", MessageBoxButtons.OK);
                return;
            }

            string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID, Role FROM Users WHERE ID=@Id AND Password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(userId));
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string role = reader.GetString(1);
                                AppUser loggedInUser = new AppUser(id, userId, role);
                                MessageBox.Show("Login success! Welcome.", "Success");

                                form1.pages.Clear();
                                form1.backStack.Clear();
                                form1.forwardStack.Clear();
                                form1.currentPageIndex = -1;
                                form1.currentPage = null;
                                // admin user controls
                                MainAdminForm mform = new MainAdminForm();

                                // Chef user controls
                                var mainmenu = new mainmenu();
                                var editProfile = new EditProfile(id);
                                var editMenu = new EditMenu1();
                                var newMenu = new NewMenuItem();
                                var viewOrders = new ViewOrders();
                                var updateOrder = new UpdateOrder(id);

                                // Manager user controls
                                var managerMain = new Manager_mainMenu();
                                var feedbackCtrl = new Manager_feedbackCtrl();
                                var topupCtrl = new Manager_topUpCtrl();
                                var discountCtrl = new Manager_discountCtrl();
                                var refundCtrl = new Manager_refundCtrl();

                                // Customer user controls
                                var customerMenu = new UC_CustomerMenu(id);
                                var customerBrowse = new Restaurant_menu(id);
                                var customerOrderStatus = new UC_OrderStatus(id);
                                var customerRefund = new UC_Refund(id);
                                var customerFeedback = new UC_Feedback(id);


                                // Add pages
                                // index 0-8
                                form1.pages.Add(mainmenu);
                                form1.pages.Add(editProfile);
                                form1.pages.Add(editMenu);
                                form1.pages.Add(newMenu);
                                form1.pages.Add(viewOrders);
                                form1.pages.Add(updateOrder);

                                // index 9-13
                                form1.pages.Add(managerMain);
                                form1.pages.Add(feedbackCtrl);
                                form1.pages.Add(topupCtrl);
                                form1.pages.Add(discountCtrl);
                                form1.pages.Add(refundCtrl);

                                // index 14-???
                                form1.pages.Add(customerMenu);
                                form1.pages.Add(customerBrowse);
                                form1.pages.Add(customerOrderStatus);
                                form1.pages.Add(customerRefund);
                                form1.pages.Add(customerFeedback);

                                //index for admin

                                // Chef event handling
                                mainmenu.EditClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(editProfile));
                                mainmenu.button2clicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(newMenu));
                                mainmenu.button4clicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(viewOrders));
                                mainmenu.UpdateMenuClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(editMenu));
                                mainmenu.button6clicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(updateOrder));

                                // Manager event handling
                                managerMain.FeedbackButtonClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(feedbackCtrl));
                                managerMain.TopupButtonClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(topupCtrl));
                                managerMain.DiscountButtonClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(discountCtrl));
                                managerMain.RefundButtonClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(refundCtrl));
                                managerMain.EditProfileButtonClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(editProfile));

                                // Customer event handling
                                customerMenu.BrowseMenuClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(customerBrowse));
                                customerMenu.OrderStatusClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(customerOrderStatus));
                                customerMenu.RefundClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(customerRefund));
                                customerMenu.FeedbackClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(customerFeedback));
                                customerMenu.ProfileClicked += (sender, ev) => form1.NavigateToPage(form1.pages.IndexOf(editProfile));


                                if (loggedInUser.Role == "Manager")
                                {
                                    form1.ShowPageAt(form1.pages.IndexOf(managerMain));
                                }
                                else if (loggedInUser.Role == "Chef")
                                {
                                    form1.ShowPageAt(form1.pages.IndexOf(mainmenu));
                                }
                                else if (loggedInUser.Role == "Customer")
                                {
                                    form1.ShowPageAt(form1.pages.IndexOf(customerMenu));
                                }
                                else if (loggedInUser.Role == "Admin")
                                {
                                    this.Hide();
                                    mform.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid name or password.", "Login Error");
                            }
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid name or password.", "Login Error");
                }
                catch (Exception ex) when (!(ex is FormatException))
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void showPwdChk_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = showPwdChk.Checked;
        }

        private void forgotPwdLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("skill issue", "lol");
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            var signup = new User_Signup();
            form1.pages.Add(this);
            form1.pages.Add(signup);
            form1.NavigateToPage(form1.pages.IndexOf(signup));
        }

        public class AppUser
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }

            public AppUser(int id, string name, string role)
            {
                ID = id;
                Name = name;
                Role = role;
            }
        }
    }
}