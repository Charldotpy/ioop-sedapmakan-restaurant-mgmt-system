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
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();
            lblQuantity.Text = "0";
        }

        public string ItemName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public decimal ItemPrice
        {
            get
            {
                if (decimal.TryParse(lblPrice.Text.Replace("RM", ""), out var price))
                    return price;
                return 0m;
            }
            set
            {
                lblPrice.Text = "RM" + value.ToString("F2");
            }
        }


        public Image ItemImage
        {
            get => pictureBoxItem.Image;
            set => pictureBoxItem.Image = value;
        }

        public int Quantity
        {
            get => int.Parse(lblQuantity.Text);
            private set => lblQuantity.Text = value.ToString();
        }

        public event EventHandler QuantityChanged;

        private void button1_Click(object sender, EventArgs e)
        {
            Quantity++;
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Quantity > 0)
            {
                Quantity--;
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }

        }
    }
}