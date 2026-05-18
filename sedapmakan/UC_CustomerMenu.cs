using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using showmembers;
using System.IO;

namespace _123
{
    public partial class UC_CustomerMenu : UserControl
    {
        public UC_CustomerMenu(int ID)
        {
            InitializeComponent();
        }

        // Events for navigation
        public event EventHandler BrowseMenuClicked;
        public event EventHandler OrderStatusClicked;
        public event EventHandler RefundClicked;
        public event EventHandler FeedbackClicked;
        public event EventHandler ProfileClicked;

        private void btnBrowseMenu_Click(object sender, EventArgs e)
        {
            BrowseMenuClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            OrderStatusClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            RefundClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedbackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}