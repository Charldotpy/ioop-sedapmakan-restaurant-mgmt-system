using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showmembers
{
    public partial class mainmenu : UserControl
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        public event EventHandler EditClicked;

        private void button5_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler UpdateMenuClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMenuClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler button2clicked;

        private void button2_Click(object sender, EventArgs e)
        {
            button2clicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler button3clicked;

        private void button3_Click(object sender, EventArgs e)
        {
            button3clicked?.Invoke(this, EventArgs.Empty);

        }

        public event EventHandler button4clicked;

        private void button4_Click(object sender, EventArgs e)
        {
            button4clicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler button6clicked;

        private void button6_Click(object sender, EventArgs e)
        {
            button6clicked?.Invoke(this, EventArgs.Empty);

        }
    }
}
