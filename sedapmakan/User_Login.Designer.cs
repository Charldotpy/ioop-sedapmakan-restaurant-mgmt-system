namespace showmembers
{
    partial class User_Login
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
            panel2 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            signUpBtn = new Button();
            showPwdChk = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtName = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Salmon;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 630);
            panel2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(87, 352);
            label5.Name = "label5";
            label5.Size = new Size(354, 56);
            label5.TabIndex = 6;
            label5.Text = "SedapMakan\r\nKitchen Management System";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_06_09_195637_removebg_preview;
            pictureBox1.Location = new Point(158, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.Salmon;
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpBtn.ForeColor = SystemColors.ControlLightLight;
            signUpBtn.Location = new Point(733, 501);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(383, 45);
            signUpBtn.TabIndex = 18;
            signUpBtn.Text = "SIGN UP";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // showPwdChk
            // 
            showPwdChk.AutoSize = true;
            showPwdChk.Font = new Font("Tahoma", 10F);
            showPwdChk.Location = new Point(968, 382);
            showPwdChk.Name = "showPwdChk";
            showPwdChk.Size = new Size(148, 25);
            showPwdChk.TabIndex = 16;
            showPwdChk.Text = "Show Password";
            showPwdChk.UseVisualStyleBackColor = true;
            showPwdChk.CheckedChanged += showPwdChk_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F);
            label4.Location = new Point(733, 297);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F);
            label3.Location = new Point(733, 192);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 14;
            label3.Text = "Sedap ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Salmon;
            label2.Location = new Point(869, 90);
            label2.Name = "label2";
            label2.Size = new Size(129, 41);
            label2.TabIndex = 11;
            label2.Text = "LOG IN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Salmon;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(733, 450);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(383, 45);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Tahoma", 10.2F);
            txtPassword.Location = new Point(733, 331);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(383, 45);
            txtPassword.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(733, 227);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(383, 45);
            txtName.TabIndex = 9;
            // 
            // User_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(signUpBtn);
            Controls.Add(showPwdChk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Name = "User_Login";
            Size = new Size(1169, 630);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox1;
        private Button signUpBtn;
        private CheckBox showPwdChk;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtName;
    }
}
