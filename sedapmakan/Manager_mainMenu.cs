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

namespace Manager
{
    public partial class Manager_mainMenu : UserControl
    {
        public Manager_mainMenu()
        {
            InitializeComponent();
        }

        public event EventHandler FeedbackButtonClicked;
        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            FeedbackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler TopupButtonClicked;
        private void topupBtn_Click(object sender, EventArgs e)
        {
            TopupButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler DiscountButtonClicked;
        private void discountBtn_Click(object sender, EventArgs e)
        {
            DiscountButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler RefundButtonClicked;
        private void refundBtn_Click(object sender, EventArgs e)
        {
            RefundButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler EditProfileButtonClicked;
        private void profileBtn_Click(object sender, EventArgs e)
        {
            EditProfileButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
