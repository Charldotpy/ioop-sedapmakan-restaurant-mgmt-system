namespace AdminLoadingScreen
{
    partial class MainAdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            mainpanel = new Panel();
            usersPanel1 = new UsersPanel();
            wallet1 = new Wallet();
            salesPanel1 = new SalesPanel();
            dashboard1 = new Dashboard();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 34);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Location = new Point(935, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 0;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Salmon;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 34);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 686);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.Salmon;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(8, 608);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(193, 47);
            button5.TabIndex = 8;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Salmon;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(8, 374);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(193, 47);
            button4.TabIndex = 6;
            button4.Text = "Customer E Wallet";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(8, 322);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(193, 47);
            button2.TabIndex = 5;
            button2.Text = "Sales Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(8, 270);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(193, 47);
            button1.TabIndex = 4;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 218);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 2;
            label1.Text = "Welcome, Admin";
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(usersPanel1);
            mainpanel.Controls.Add(wallet1);
            mainpanel.Controls.Add(salesPanel1);
            mainpanel.Controls.Add(dashboard1);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(212, 34);
            mainpanel.Margin = new Padding(2);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(745, 686);
            mainpanel.TabIndex = 2;
            // 
            // usersPanel1
            // 
            usersPanel1.Location = new Point(0, 0);
            usersPanel1.Margin = new Padding(1, 2, 1, 2);
            usersPanel1.Name = "usersPanel1";
            usersPanel1.Size = new Size(745, 686);
            usersPanel1.TabIndex = 3;
            // 
            // wallet1
            // 
            wallet1.Location = new Point(0, 0);
            wallet1.Margin = new Padding(1, 2, 1, 2);
            wallet1.Name = "wallet1";
            wallet1.Size = new Size(745, 686);
            wallet1.TabIndex = 2;
            // 
            // salesPanel1
            // 
            salesPanel1.Location = new Point(0, 0);
            salesPanel1.Margin = new Padding(1, 2, 1, 2);
            salesPanel1.Name = "salesPanel1";
            salesPanel1.Size = new Size(745, 686);
            salesPanel1.TabIndex = 1;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Margin = new Padding(1, 2, 1, 2);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(745, 686);
            dashboard1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = showmembers.Properties.Resources.Screenshot_2025_06_09_195637_removebg_preview;
            pictureBox1.Location = new Point(8, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // MainAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 720);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainAdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel mainpanel;
        private UsersPanel usersPanel1;
        private Wallet wallet1;
        private SalesPanel salesPanel1;
        private Dashboard dashboard1;
        private PictureBox pictureBox1;
    }
}