namespace Manager
{
    partial class Manager_mainMenu
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            feedbackBtn = new Button();
            topupBtn = new Button();
            discountBtn = new Button();
            refundBtn = new Button();
            profileBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = showmembers.Properties.Resources.Screenshot_2025_06_09_195637_removebg_preview;
            pictureBox1.Location = new Point(478, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(481, 232);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 6;
            label1.Text = "Welcome, Manager";
            // 
            // feedbackBtn
            // 
            feedbackBtn.BackColor = Color.Salmon;
            feedbackBtn.Cursor = Cursors.Hand;
            feedbackBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackBtn.ForeColor = SystemColors.ControlLightLight;
            feedbackBtn.Location = new Point(434, 285);
            feedbackBtn.Name = "feedbackBtn";
            feedbackBtn.Size = new Size(300, 50);
            feedbackBtn.TabIndex = 7;
            feedbackBtn.Text = "View Feedback";
            feedbackBtn.UseVisualStyleBackColor = false;
            feedbackBtn.Click += feedbackBtn_Click;
            // 
            // topupBtn
            // 
            topupBtn.BackColor = Color.Salmon;
            topupBtn.Cursor = Cursors.Hand;
            topupBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topupBtn.ForeColor = SystemColors.ControlLightLight;
            topupBtn.Location = new Point(434, 350);
            topupBtn.Name = "topupBtn";
            topupBtn.Size = new Size(300, 50);
            topupBtn.TabIndex = 8;
            topupBtn.Text = "Customer Top-up";
            topupBtn.UseVisualStyleBackColor = false;
            topupBtn.Click += topupBtn_Click;
            // 
            // discountBtn
            // 
            discountBtn.BackColor = Color.Salmon;
            discountBtn.Cursor = Cursors.Hand;
            discountBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountBtn.ForeColor = SystemColors.ControlLightLight;
            discountBtn.Location = new Point(434, 415);
            discountBtn.Name = "discountBtn";
            discountBtn.Size = new Size(300, 50);
            discountBtn.TabIndex = 9;
            discountBtn.Text = "Manage Discounts";
            discountBtn.UseVisualStyleBackColor = false;
            discountBtn.Click += discountBtn_Click;
            // 
            // refundBtn
            // 
            refundBtn.BackColor = Color.Salmon;
            refundBtn.Cursor = Cursors.Hand;
            refundBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refundBtn.ForeColor = SystemColors.ControlLightLight;
            refundBtn.Location = new Point(434, 483);
            refundBtn.Name = "refundBtn";
            refundBtn.Size = new Size(300, 50);
            refundBtn.TabIndex = 10;
            refundBtn.Text = "Customer Refunds";
            refundBtn.UseVisualStyleBackColor = false;
            refundBtn.Click += refundBtn_Click;
            // 
            // profileBtn
            // 
            profileBtn.BackColor = Color.Salmon;
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileBtn.ForeColor = SystemColors.ControlLightLight;
            profileBtn.Location = new Point(434, 551);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(300, 50);
            profileBtn.TabIndex = 11;
            profileBtn.Text = "Edit Profile";
            profileBtn.UseVisualStyleBackColor = false;
            profileBtn.Click += profileBtn_Click;
            // 
            // Manager_mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Salmon;
            Controls.Add(profileBtn);
            Controls.Add(refundBtn);
            Controls.Add(discountBtn);
            Controls.Add(topupBtn);
            Controls.Add(feedbackBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_mainMenu";
            Size = new Size(1169, 630);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button feedbackBtn;
        private Button topupBtn;
        private Button discountBtn;
        private Button refundBtn;
        private Button profileBtn;
    }
}
