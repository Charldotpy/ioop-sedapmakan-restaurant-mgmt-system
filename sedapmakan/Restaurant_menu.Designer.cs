namespace showmembers
{
    partial class Restaurant_menu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelMenu = new FlowLayoutPanel();
            listViewOrders = new ListView();
            Item = new ColumnHeader();
            Quantity = new ColumnHeader();
            Total = new ColumnHeader();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            lblTotalPrice = new Label();
            lblTotalItems = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            flowLayoutPanelMenu.AutoScroll = true;
            flowLayoutPanelMenu.Location = new Point(13, 57);
            flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            flowLayoutPanelMenu.Size = new Size(720, 563);
            flowLayoutPanelMenu.TabIndex = 0;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { Item, Quantity, Total });
            listViewOrders.Location = new Point(739, 91);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(357, 423);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // Item
            // 
            Item.Text = "Item";
            Item.Width = 150;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 70;
            // 
            // Total
            // 
            Total.Text = "Total";
            Total.Width = 80;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(739, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter your name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblTotalPrice);
            groupBox1.Controls.Add(lblTotalItems);
            groupBox1.Location = new Point(739, 507);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(218, 35);
            button1.Name = "button1";
            button1.Size = new Size(123, 52);
            button1.TabIndex = 2;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(27, 67);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(44, 20);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "Price:";
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Location = new Point(27, 35);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(89, 20);
            lblTotalItems.TabIndex = 0;
            lblTotalItems.Text = "Total items: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 21);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Main Menu";
            // 
            // Restaurant_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(listViewOrders);
            Controls.Add(flowLayoutPanelMenu);
            Name = "Restaurant_menu";
            Size = new Size(1105, 631);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelMenu;
        private ListView listViewOrders;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button1;
        private Label lblTotalPrice;
        private Label lblTotalItems;
        private Label label3;
        private ColumnHeader Item;
        private ColumnHeader Quantity;
        private ColumnHeader Total;
    }
}
