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
    public partial class MenuItemControl : UserControl
    {
        private int quantity = 0;

        public string ItemName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public decimal ItemPrice
        {
            get => decimal.Parse(lblPrice.Text.Replace("$", ""));
            set => lblPrice.Text = $"${value:F2}";
        }
        /*
        public string ImagePath
        {
            set
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, "Resources", "MenuImages", value);
                    if (File.Exists(fullPath))
                        pictureBox1.Image = Image.FromFile(fullPath);
                    else
                        pictureBox1.Image = Properties.Resources.DefaultImage; // Add one to Resources
                }
                catch
                {
                    pictureBox1.Image = Properties.Resources.DefaultImage;
                }
            }
        }

        public MenuItemControl()
        {
            InitializeComponent();

            btnPlus.Click += (s, e) =>
            {
                quantity++;
                lblQty.Text = quantity.ToString();
            };

            btnMinus.Click += (s, e) =>
            {
                if (quantity > 0) quantity--;
                lblQty.Text = quantity.ToString();
            };
        */
        }
    }
