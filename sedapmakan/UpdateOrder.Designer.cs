namespace showmembers
{
    partial class UpdateOrder
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
            label1 = new Label();
            listView1 = new ListView();
            OrderID = new ColumnHeader();
            MenuItem = new ColumnHeader();
            Quantity = new ColumnHeader();
            Item_Total_Price = new ColumnHeader();
            Status = new ColumnHeader();
            remark = new ColumnHeader();
            btnPending = new Button();
            btnInProgress = new Button();
            btnCompleted = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(464, 40);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 3;
            label1.Text = "Current Orders";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { OrderID, MenuItem, Quantity, Item_Total_Price, Status, remark });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(281, 130);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(607, 360);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // OrderID
            // 
            OrderID.Text = "Order ID";
            OrderID.Width = 80;
            // 
            // MenuItem
            // 
            MenuItem.Text = "Menu Item";
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
            // remark
            // 
            remark.Text = "Remark";
            remark.Width = 80;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.Salmon;
            btnPending.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPending.ForeColor = SystemColors.ControlLightLight;
            btnPending.Location = new Point(281, 507);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(134, 50);
            btnPending.TabIndex = 4;
            btnPending.Text = "Pending";
            btnPending.UseVisualStyleBackColor = false;
            btnPending.Click += btnPending_Click_1;
            // 
            // btnInProgress
            // 
            btnInProgress.BackColor = Color.Salmon;
            btnInProgress.Font = new Font("Tahoma", 10.2F);
            btnInProgress.ForeColor = SystemColors.ControlLightLight;
            btnInProgress.Location = new Point(517, 507);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(134, 50);
            btnInProgress.TabIndex = 5;
            btnInProgress.Text = "In Progress";
            btnInProgress.UseVisualStyleBackColor = false;
            btnInProgress.Click += btnInProgress_Click_1;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = Color.Salmon;
            btnCompleted.Font = new Font("Tahoma", 10.2F);
            btnCompleted.ForeColor = SystemColors.ControlLightLight;
            btnCompleted.Location = new Point(754, 507);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(134, 50);
            btnCompleted.TabIndex = 6;
            btnCompleted.Text = "Completed";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnCompleted_Click_1;
            // 
            // UpdateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(btnCompleted);
            Controls.Add(btnInProgress);
            Controls.Add(btnPending);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "UpdateOrder";
            Size = new Size(1169, 630);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader OrderID;
        private ColumnHeader MenuItem;
        private ColumnHeader Quantity;
        private ColumnHeader Item_Total_Price;
        private ColumnHeader Status;
        private ColumnHeader remark;
        private Button btnPending;
        private Button btnInProgress;
        private Button btnCompleted;
    }
}
