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
    public partial class SalesPanel : UserControl
    {
        public SalesPanel()
        {
            InitializeComponent();

            DisplaySalesByDate();
        }
        public void DisplaySalesByDate()
        {
            AddSalesData data = new AddSalesData();

            usersgrid2.DataSource = data.GetSalesByDate();
        }

        public void DisplaySalesByCategory()
        {
            AddSalesData data = new AddSalesData();

            usersgrid2.DataSource = data.GetSalesByCategory();
        }

        private void usersgrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndate_Click(object sender, EventArgs e)
        {
            DisplaySalesByDate();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            DisplaySalesByCategory();
        }
    }
}
