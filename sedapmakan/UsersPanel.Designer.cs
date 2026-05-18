namespace AdminLoadingScreen
{
    partial class UsersPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.usersgrid = new System.Windows.Forms.DataGridView();
            //this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.accountpassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailadd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ewalletball = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.createbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usersgrid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 452);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.user_id);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dob);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.clearbtn);
            this.panel2.Controls.Add(this.updatebtn);
            this.panel2.Controls.Add(this.createbtn);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.ewalletball);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.accountpassword);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.emailadd);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nationality);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.phone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.fullname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(29, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 329);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "DATABASE";
            // 
            // usersgrid
            // 
            this.usersgrid.AllowUserToAddRows = false;
            this.usersgrid.AllowUserToDeleteRows = false;
            this.usersgrid.AllowUserToResizeColumns = false;
            this.usersgrid.AllowUserToResizeRows = false;
            this.usersgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgrid.Location = new System.Drawing.Point(26, 51);
            this.usersgrid.Name = "usersgrid";
            this.usersgrid.ReadOnly = true;
            this.usersgrid.RowHeadersVisible = false;
            this.usersgrid.RowHeadersWidth = 82;
            this.usersgrid.RowTemplate.Height = 33;
            this.usersgrid.Size = new System.Drawing.Size(999, 370);
            this.usersgrid.TabIndex = 4;
            this.usersgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgrid_CellClick);
            this.usersgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // fullname
            // 
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Location = new System.Drawing.Point(148, 103);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(195, 31);
            this.fullname.TabIndex = 8;
            this.fullname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Location = new System.Drawing.Point(148, 149);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(195, 31);
            this.phone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // nationality
            // 
            this.nationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nationality.Location = new System.Drawing.Point(148, 196);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(195, 31);
            this.nationality.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nationality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "DOB";
            // 
            // accountpassword
            // 
            this.accountpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountpassword.Location = new System.Drawing.Point(501, 196);
            this.accountpassword.Name = "accountpassword";
            this.accountpassword.Size = new System.Drawing.Size(217, 31);
            this.accountpassword.TabIndex = 21;
            this.accountpassword.TextChanged += new System.EventHandler(this.accountpassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(374, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Password";
            // 
            // emailadd
            // 
            this.emailadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailadd.Location = new System.Drawing.Point(501, 149);
            this.emailadd.Name = "emailadd";
            this.emailadd.Size = new System.Drawing.Size(217, 31);
            this.emailadd.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(374, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(374, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Role";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(374, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Account Information";
            // 
            // ewalletball
            // 
            this.ewalletball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ewalletball.Location = new System.Drawing.Point(875, 103);
            this.ewalletball.Name = "ewalletball";
            this.ewalletball.Size = new System.Drawing.Size(125, 31);
            this.ewalletball.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(740, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 29);
            this.label16.TabIndex = 25;
            this.label16.Text = "Balance";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(740, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 29);
            this.label17.TabIndex = 24;
            this.label17.Text = "E Wallet Balance";
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Customer",
            "Chef",
            "Admin"});
            this.role.Location = new System.Drawing.Point(501, 98);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(217, 33);
            this.role.TabIndex = 28;
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.Color.Salmon;
            this.createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createbtn.FlatAppearance.BorderSize = 0;
            this.createbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.createbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.Color.White;
            this.createbtn.Location = new System.Drawing.Point(423, 265);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(140, 48);
            this.createbtn.TabIndex = 29;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = false;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Salmon;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(569, 265);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(140, 48);
            this.updatebtn.TabIndex = 30;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Salmon;
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(715, 265);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(140, 48);
            this.clearbtn.TabIndex = 31;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Salmon;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(861, 265);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(140, 48);
            this.deletebtn.TabIndex = 32;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(148, 240);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(195, 31);
            this.dob.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(740, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID:";
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.BackColor = System.Drawing.SystemColors.Control;
            this.user_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id.ForeColor = System.Drawing.Color.Black;
            this.user_id.Location = new System.Drawing.Point(813, 198);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(72, 29);
            this.user_id.TabIndex = 35;
            this.user_id.Text = "None";
            // 
            // UsersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsersPanel";
            this.Size = new System.Drawing.Size(1117, 857);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView usersgrid;
        private System.Windows.Forms.Label label3;
        //private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accountpassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailadd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ewalletball;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label label8;
    }
}
