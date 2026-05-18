using showmembers;
using System.IO;

namespace _123
{
    partial class UC_CustomerMenu
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBrowseMenu = new Button();
            btnOrderStatus = new Button();
            btnRefund = new Button();
            btnFeedback = new Button();
            btnProfile = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(241, 0);
            label1.Name = "label1";
            label1.Size = new Size(686, 80);
            label1.TabIndex = 0;
            label1.Text = "SedapMakan Customer Portal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 80);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnBrowseMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(btnOrderStatus, 0, 1);
            tableLayoutPanel1.Controls.Add(btnRefund, 0, 2);
            tableLayoutPanel1.Controls.Add(btnFeedback, 0, 3);
            tableLayoutPanel1.Controls.Add(btnProfile, 0, 4);
            tableLayoutPanel1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(57, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1052, 542);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBrowseMenu
            // 
            btnBrowseMenu.BackColor = Color.Salmon;
            btnBrowseMenu.Dock = DockStyle.Fill;
            btnBrowseMenu.FlatStyle = FlatStyle.Flat;
            btnBrowseMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBrowseMenu.ForeColor = Color.White;
            btnBrowseMenu.Location = new Point(23, 27);
            btnBrowseMenu.Margin = new Padding(23, 27, 23, 27);
            btnBrowseMenu.Name = "btnBrowseMenu";
            btnBrowseMenu.Size = new Size(1006, 54);
            btnBrowseMenu.TabIndex = 0;
            btnBrowseMenu.Text = "Browse Menu And Order";
            btnBrowseMenu.UseVisualStyleBackColor = false;
            btnBrowseMenu.Click += btnBrowseMenu_Click;
            // 
            // btnOrderStatus
            // 
            btnOrderStatus.BackColor = Color.Salmon;
            btnOrderStatus.Dock = DockStyle.Fill;
            btnOrderStatus.FlatStyle = FlatStyle.Flat;
            btnOrderStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnOrderStatus.ForeColor = Color.White;
            btnOrderStatus.Location = new Point(23, 135);
            btnOrderStatus.Margin = new Padding(23, 27, 23, 27);
            btnOrderStatus.Name = "btnOrderStatus";
            btnOrderStatus.Size = new Size(1006, 54);
            btnOrderStatus.TabIndex = 1;
            btnOrderStatus.Text = "Check Order Status";
            btnOrderStatus.UseVisualStyleBackColor = false;
            btnOrderStatus.Click += btnOrderStatus_Click;
            // 
            // btnRefund
            // 
            btnRefund.BackColor = Color.Salmon;
            btnRefund.Dock = DockStyle.Fill;
            btnRefund.FlatStyle = FlatStyle.Flat;
            btnRefund.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRefund.ForeColor = Color.White;
            btnRefund.Location = new Point(23, 243);
            btnRefund.Margin = new Padding(23, 27, 23, 27);
            btnRefund.Name = "btnRefund";
            btnRefund.Size = new Size(1006, 54);
            btnRefund.TabIndex = 2;
            btnRefund.Text = "Request Refund";
            btnRefund.UseVisualStyleBackColor = false;
            btnRefund.Click += btnRefund_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.Salmon;
            btnFeedback.Dock = DockStyle.Fill;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnFeedback.ForeColor = Color.White;
            btnFeedback.Location = new Point(23, 351);
            btnFeedback.Margin = new Padding(23, 27, 23, 27);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(1006, 54);
            btnFeedback.TabIndex = 3;
            btnFeedback.Text = "Give Feedback";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Salmon;
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(23, 459);
            btnProfile.Margin = new Padding(23, 27, 23, 27);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(1006, 56);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Update Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(0, 80);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(57, 40, 57, 40);
            panel2.Size = new Size(1169, 550);
            panel2.TabIndex = 3;
            // 
            // UC_CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_CustomerMenu";
            Size = new Size(1169, 630);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBrowseMenu;
        private Button btnOrderStatus;
        private Button btnRefund;
        private Button btnFeedback;
        private Button btnProfile;
        private Panel panel2;
    }
}