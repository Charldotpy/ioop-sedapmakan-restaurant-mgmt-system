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
    public partial class Manager_discountCtrl : UserControl
    {
        public Manager_discountCtrl()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            discountPnl.Controls.Clear();
            Manager_discountAddCtrl discountAdd = new Manager_discountAddCtrl();

            discountPnl.Controls.Add(discountAdd);
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            discountPnl.Controls.Clear();
            Manager_discountManageCtrl discountMng = new Manager_discountManageCtrl();

            discountPnl.Controls.Add(discountMng);
        }
    }
}
