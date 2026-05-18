using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLoadingScreen
{
    public partial class MainAdminForm : Form
    {

        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                //LogInMenu logInMenu = new LogInMenu();
                //logInMenu.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            dashboard1.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(dashboard1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            usersPanel1.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(usersPanel1);
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void usersPanel1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            salesPanel1.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(salesPanel1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            wallet1.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(wallet1);
        }
    }
}
