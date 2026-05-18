namespace _123
{
    partial class UC_OrderStatus
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            listViewOrders = new ListView();
            columnOrderID = new ColumnHeader();
            columnItem = new ColumnHeader();
            columnStatus = new ColumnHeader();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(411, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(347, 57);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Order Status";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columnOrderID, columnItem, columnStatus });
            listViewOrders.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewOrders.Location = new Point(307, 92);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(555, 400);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // columnOrderID
            // 
            columnOrderID.Text = "Order ID";
            columnOrderID.Width = 100;
            // 
            // columnItem
            // 
            columnItem.Text = "Item";
            columnItem.Width = 250;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 200;
            // 
            // UC_OrderStatus
            // 
            BackColor = Color.Salmon;
            Controls.Add(labelTitle);
            Controls.Add(listViewOrders);
            Name = "UC_OrderStatus";
            Size = new Size(1169, 630);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnOrderID;
        private System.Windows.Forms.ColumnHeader columnItem;
        private System.Windows.Forms.ColumnHeader columnStatus;
    }
}