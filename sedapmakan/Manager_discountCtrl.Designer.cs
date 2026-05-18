namespace Manager
{
    partial class Manager_discountCtrl
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
            manageBtn = new Button();
            createBtn = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            discountPnl = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // manageBtn
            // 
            manageBtn.BackColor = Color.Salmon;
            manageBtn.Cursor = Cursors.Hand;
            manageBtn.Font = new Font("Tahoma", 10.2F);
            manageBtn.ForeColor = SystemColors.ControlLightLight;
            manageBtn.Location = new Point(26, 356);
            manageBtn.Margin = new Padding(3, 4, 3, 4);
            manageBtn.Name = "manageBtn";
            manageBtn.Size = new Size(218, 50);
            manageBtn.TabIndex = 5;
            manageBtn.Text = "Manage Existing";
            manageBtn.UseVisualStyleBackColor = false;
            manageBtn.Click += manageBtn_Click;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.Salmon;
            createBtn.Cursor = Cursors.Hand;
            createBtn.Font = new Font("Tahoma", 10.2F);
            createBtn.ForeColor = SystemColors.ControlLightLight;
            createBtn.Location = new Point(26, 284);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(218, 50);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create New";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(21, 188);
            label5.Name = "label5";
            label5.Size = new Size(223, 28);
            label5.TabIndex = 6;
            label5.Text = "Discount Manager";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = showmembers.Properties.Resources.Screenshot_2025_06_09_195637_removebg_preview;
            pictureBox1.Location = new Point(26, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Salmon;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(manageBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(createBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 630);
            panel2.TabIndex = 16;
            // 
            // discountPnl
            // 
            discountPnl.AutoScroll = true;
            discountPnl.Location = new Point(270, 4);
            discountPnl.Margin = new Padding(3, 4, 3, 4);
            discountPnl.Name = "discountPnl";
            discountPnl.Size = new Size(896, 622);
            discountPnl.TabIndex = 17;
            // 
            // Manager_discountCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(discountPnl);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_discountCtrl";
            Size = new Size(1169, 630);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button manageBtn;
        private System.Windows.Forms.Button createBtn;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel2;
        private FlowLayoutPanel discountPnl;
    }
}
