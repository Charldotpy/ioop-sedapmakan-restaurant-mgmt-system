using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showmembers
{
    public partial class editingmenu : UserControl
    {
        public editingmenu()
        {
            InitializeComponent();
        }
        public int ItemId { get; set; }
        public string ItemName
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public decimal ItemPrice
        {
            get
            {
                if (decimal.TryParse(textBox2.Text.Replace("RM", ""), out var price))
                    return price;
                return 0m;
            }
            set
            {
                textBox2.Text = "RM" + value.ToString("F2");
            }
        }

        public Image ItemImage
        {
            get => pictureBoxItem.Image;
            set => pictureBoxItem.Image = value;
        }

        public string Availability
        {
            get
            {
                return radioButton1.Checked ? "1" : "0";
            }
            set
            {
                if (value == "1")
                {
                    radioButton1.Checked = true; // this is the available one
                }
                else
                {
                    radioButton2.Checked = true;  // not available one
                }
            }
        }
    }
}
