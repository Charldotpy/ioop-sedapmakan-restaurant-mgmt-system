namespace showmembers
{
    partial class ViewOrders
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
            listView1 = new ListView();
            OrderID = new ColumnHeader();
            MenuItem = new ColumnHeader();
            Quantity = new ColumnHeader();
            Item_Total_Price = new ColumnHeader();
            Status = new ColumnHeader();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { OrderID, MenuItem, Quantity, Item_Total_Price, Status });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(315, 135);
            listView1.Name = "listView1";
            listView1.Size = new Size(538, 360);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // OrderID
            // 
            OrderID.Text = "OrderID";
            OrderID.Width = 80;
            // 
            // MenuItem
            // 
            MenuItem.Text = "MenuItem";
            MenuItem.Width = 150;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 80;
            // 
            // Item_Total_Price
            // 
            Item_Total_Price.Text = "Item Total";
            Item_Total_Price.Width = 100;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(464, 40);
            label2.Name = "label2";
            label2.Size = new Size(240, 41);
            label2.TabIndex = 4;
            label2.Text = "Current Orders";
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(label2);
            Controls.Add(listView1);
            Name = "ViewOrders";
            Size = new Size(1169, 630);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader OrderID;
        private ColumnHeader MenuItem;
        private ColumnHeader Quantity;
        private ColumnHeader Item_Total_Price;
        private ColumnHeader Status;
        private Label label2;
    }
}
