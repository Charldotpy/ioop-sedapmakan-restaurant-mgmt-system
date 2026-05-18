namespace showmembers
{
    partial class User_Signup
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
            nameTxt = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            emailTxt = new TextBox();
            label6 = new Label();
            signupBtn = new Button();
            phoneTxt = new TextBox();
            label2 = new Label();
            nationalityCmb = new ComboBox();
            dobPicker = new DateTimePicker();
            emailCmb = new ComboBox();
            countryCodeCmb = new ComboBox();
            label7 = new Label();
            pwdTxt = new TextBox();
            pwdGuideLbl = new Label();
            pwdStrengthPnl = new Panel();
            label8 = new Label();
            customerRb = new RadioButton();
            chefRb = new RadioButton();
            managerRb = new RadioButton();
            signUpPnl = new Panel();
            adminRb = new RadioButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            signUpPnl.SuspendLayout();
            SuspendLayout();
            // 
            // nameTxt
            // 
            nameTxt.BorderStyle = BorderStyle.FixedSingle;
            nameTxt.Font = new Font("Tahoma", 10.2F);
            nameTxt.Location = new Point(680, 49);
            nameTxt.Multiline = true;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(383, 29);
            nameTxt.TabIndex = 0;
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
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(163, 352);
            label5.Name = "label5";
            label5.Size = new Size(202, 56);
            label5.TabIndex = 6;
            label5.Text = "SedapMakan\r\nAccount Sign Up";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F);
            label3.Location = new Point(680, 14);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F);
            label4.Location = new Point(680, 89);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 5;
            label4.Text = "Nationality";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F);
            label1.Location = new Point(680, 164);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 10;
            label1.Text = "Date of Birth";
            // 
            // emailTxt
            // 
            emailTxt.BorderStyle = BorderStyle.FixedSingle;
            emailTxt.Font = new Font("Tahoma", 10.2F);
            emailTxt.Location = new Point(680, 274);
            emailTxt.Multiline = true;
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(250, 29);
            emailTxt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F);
            label6.Location = new Point(680, 239);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.Salmon;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = SystemColors.ControlLightLight;
            signupBtn.Location = new Point(680, 570);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(383, 45);
            signupBtn.TabIndex = 8;
            signupBtn.Text = "SIGN UP";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // phoneTxt
            // 
            phoneTxt.BorderStyle = BorderStyle.FixedSingle;
            phoneTxt.Font = new Font("Tahoma", 10.2F);
            phoneTxt.Location = new Point(760, 349);
            phoneTxt.Multiline = true;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(303, 29);
            phoneTxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F);
            label2.Location = new Point(680, 314);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 14;
            label2.Text = "Phone Number";
            // 
            // nationalityCmb
            // 
            nationalityCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            nationalityCmb.Font = new Font("Tahoma", 10.2F);
            nationalityCmb.FormattingEnabled = true;
            nationalityCmb.IntegralHeight = false;
            nationalityCmb.Items.AddRange(new object[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "I-Kiribati", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivian", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "New Zealander", "Ni-Vanuatu", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean" });
            nationalityCmb.Location = new Point(680, 124);
            nationalityCmb.Name = "nationalityCmb";
            nationalityCmb.Size = new Size(383, 29);
            nationalityCmb.TabIndex = 15;
            // 
            // dobPicker
            // 
            dobPicker.CalendarFont = new Font("Tahoma", 10.2F);
            dobPicker.CustomFormat = "dd-MM-yyyy";
            dobPicker.Font = new Font("Tahoma", 10.2F);
            dobPicker.Format = DateTimePickerFormat.Custom;
            dobPicker.Location = new Point(680, 198);
            dobPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(383, 28);
            dobPicker.TabIndex = 16;
            // 
            // emailCmb
            // 
            emailCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            emailCmb.Font = new Font("Tahoma", 10.2F);
            emailCmb.FormattingEnabled = true;
            emailCmb.IntegralHeight = false;
            emailCmb.Items.AddRange(new object[] { "@gmail.com", "@hotmail.com", "@yahoo.com" });
            emailCmb.Location = new Point(930, 274);
            emailCmb.Name = "emailCmb";
            emailCmb.Size = new Size(133, 29);
            emailCmb.TabIndex = 17;
            // 
            // countryCodeCmb
            // 
            countryCodeCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            countryCodeCmb.Font = new Font("Tahoma", 10.2F);
            countryCodeCmb.FormattingEnabled = true;
            countryCodeCmb.IntegralHeight = false;
            countryCodeCmb.Items.AddRange(new object[] { "+1", "+20", "+30", "+31", "+32", "+33", "+34", "+36", "+39", "+40", "+41", "+43", "+44", "+45", "+46", "+47", "+48", "+49", "+51", "+52", "+53", "+54", "+55", "+56", "+57", "+58", "+60", "+61", "+62", "+63", "+64", "+65", "+66", "+7", "+81", "+82", "+84", "+86", "+90", "+91", "+92", "+93", "+94", "+95", "+98", "+212", "+213", "+216", "+218", "+220", "+221", "+222", "+223", "+224", "+225", "+226", "+227", "+228", "+229", "+230", "+231", "+232", "+233", "+234", "+235", "+236", "+237", "+238", "+239", "+240", "+241", "+242", "+243", "+244", "+245", "+246", "+247", "+248", "+249", "+250", "+251", "+252", "+253", "+254", "+255", "+256", "+257", "+258", "+260", "+261", "+262", "+263", "+264", "+265", "+266", "+267", "+268", "+269", "+290", "+291", "+297", "+298", "+299", "+350", "+351", "+352", "+353", "+354", "+355", "+356", "+357", "+358", "+359", "+370", "+371", "+372", "+373", "+374", "+375", "+376", "+377", "+378", "+380", "+381", "+382", "+383", "+385", "+386", "+387", "+389", "+420", "+421", "+423", "+500", "+501", "+502", "+503", "+504", "+505", "+506", "+507", "+508", "+509", "+590", "+591", "+592", "+593", "+594", "+595", "+596", "+597", "+598", "+599", "+670", "+672", "+673", "+674", "+675", "+676", "+677", "+678", "+679", "+680", "+681", "+682", "+683", "+684", "+685", "+686", "+687", "+688", "+689", "+800", "+878", "+881", "+979" });
            countryCodeCmb.Location = new Point(680, 349);
            countryCodeCmb.Name = "countryCodeCmb";
            countryCodeCmb.Size = new Size(80, 29);
            countryCodeCmb.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F);
            label7.Location = new Point(680, 389);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 19;
            label7.Text = "Password";
            // 
            // pwdTxt
            // 
            pwdTxt.BorderStyle = BorderStyle.FixedSingle;
            pwdTxt.Font = new Font("Tahoma", 10.2F);
            pwdTxt.Location = new Point(680, 424);
            pwdTxt.Multiline = true;
            pwdTxt.Name = "pwdTxt";
            pwdTxt.Size = new Size(383, 29);
            pwdTxt.TabIndex = 20;
            pwdTxt.KeyUp += pwdTxt_KeyUp;
            pwdTxt.Leave += pwdTxt_Leave;
            // 
            // pwdGuideLbl
            // 
            pwdGuideLbl.AutoSize = true;
            pwdGuideLbl.Cursor = Cursors.Hand;
            pwdGuideLbl.Font = new Font("Tahoma", 8F, FontStyle.Underline);
            pwdGuideLbl.ForeColor = Color.Salmon;
            pwdGuideLbl.Location = new Point(679, 456);
            pwdGuideLbl.Name = "pwdGuideLbl";
            pwdGuideLbl.Size = new Size(104, 17);
            pwdGuideLbl.TabIndex = 21;
            pwdGuideLbl.Text = "Password Guide";
            pwdGuideLbl.Click += pwdGuideLbl_Click;
            // 
            // pwdStrengthPnl
            // 
            pwdStrengthPnl.BackColor = Color.Red;
            pwdStrengthPnl.Location = new Point(930, 456);
            pwdStrengthPnl.Name = "pwdStrengthPnl";
            pwdStrengthPnl.Size = new Size(133, 17);
            pwdStrengthPnl.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F);
            label8.Location = new Point(680, 491);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 23;
            label8.Text = "Role";
            // 
            // customerRb
            // 
            customerRb.AutoSize = true;
            customerRb.Font = new Font("Tahoma", 10.2F);
            customerRb.Location = new Point(680, 526);
            customerRb.Name = "customerRb";
            customerRb.Size = new Size(102, 25);
            customerRb.TabIndex = 0;
            customerRb.TabStop = true;
            customerRb.Text = "Customer";
            customerRb.UseVisualStyleBackColor = true;
            // 
            // chefRb
            // 
            chefRb.AutoSize = true;
            chefRb.Font = new Font("Tahoma", 10.2F);
            chefRb.Location = new Point(795, 526);
            chefRb.Name = "chefRb";
            chefRb.Size = new Size(64, 25);
            chefRb.TabIndex = 1;
            chefRb.TabStop = true;
            chefRb.Text = "Chef";
            chefRb.UseVisualStyleBackColor = true;
            // 
            // managerRb
            // 
            managerRb.AutoSize = true;
            managerRb.Font = new Font("Tahoma", 10.2F);
            managerRb.Location = new Point(877, 526);
            managerRb.Name = "managerRb";
            managerRb.Size = new Size(95, 25);
            managerRb.TabIndex = 2;
            managerRb.TabStop = true;
            managerRb.Text = "Manager";
            managerRb.UseVisualStyleBackColor = true;
            // 
            // signUpPnl
            // 
            signUpPnl.Controls.Add(adminRb);
            signUpPnl.Controls.Add(managerRb);
            signUpPnl.Controls.Add(chefRb);
            signUpPnl.Controls.Add(customerRb);
            signUpPnl.Controls.Add(label8);
            signUpPnl.Controls.Add(pwdStrengthPnl);
            signUpPnl.Controls.Add(pwdGuideLbl);
            signUpPnl.Controls.Add(pwdTxt);
            signUpPnl.Controls.Add(label7);
            signUpPnl.Controls.Add(countryCodeCmb);
            signUpPnl.Controls.Add(emailCmb);
            signUpPnl.Controls.Add(dobPicker);
            signUpPnl.Controls.Add(nationalityCmb);
            signUpPnl.Controls.Add(label2);
            signUpPnl.Controls.Add(phoneTxt);
            signUpPnl.Controls.Add(signupBtn);
            signUpPnl.Controls.Add(label6);
            signUpPnl.Controls.Add(emailTxt);
            signUpPnl.Controls.Add(label1);
            signUpPnl.Controls.Add(label4);
            signUpPnl.Controls.Add(label3);
            signUpPnl.Controls.Add(panel2);
            signUpPnl.Controls.Add(nameTxt);
            signUpPnl.Location = new Point(0, 0);
            signUpPnl.Name = "signUpPnl";
            signUpPnl.Size = new Size(1169, 630);
            signUpPnl.TabIndex = 1;
            // 
            // adminRb
            // 
            adminRb.AutoSize = true;
            adminRb.Font = new Font("Tahoma", 10.2F);
            adminRb.Location = new Point(985, 526);
            adminRb.Name = "adminRb";
            adminRb.Size = new Size(78, 25);
            adminRb.TabIndex = 24;
            adminRb.TabStop = true;
            adminRb.Text = "Admin";
            adminRb.UseVisualStyleBackColor = true;
            // 
            // User_Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(signUpPnl);
            Name = "User_Signup";
            Size = new Size(1169, 630);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            signUpPnl.ResumeLayout(false);
            signUpPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nameTxt;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox emailTxt;
        private Label label6;
        private Button signupBtn;
        private TextBox phoneTxt;
        private Label label2;
        private ComboBox nationalityCmb;
        private DateTimePicker dobPicker;
        private ComboBox emailCmb;
        private ComboBox countryCodeCmb;
        private Label label7;
        private TextBox pwdTxt;
        private Label pwdGuideLbl;
        private Panel pwdStrengthPnl;
        private Label label8;
        private RadioButton customerRb;
        private RadioButton chefRb;
        private RadioButton managerRb;
        private Panel signUpPnl;
        private RadioButton adminRb;
    }
}
