namespace showmembers
{
    partial class EditProfile
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
            pwdStrengthPnl = new Panel();
            pwdGuideLbl = new Label();
            pwdTxt = new TextBox();
            label7 = new Label();
            countryCodeCmb = new ComboBox();
            emailCmb = new ComboBox();
            dobPicker = new DateTimePicker();
            nationalityCmb = new ComboBox();
            label2 = new Label();
            saveBtn = new Button();
            label6 = new Label();
            emailTxt = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            phoneTxt = new TextBox();
            panel2 = new Panel();
            nameTxt = new TextBox();
            signUpPnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            signUpPnl.SuspendLayout();
            SuspendLayout();
            // 
            // pwdStrengthPnl
            // 
            pwdStrengthPnl.BackColor = Color.Red;
            pwdStrengthPnl.Location = new Point(930, 508);
            pwdStrengthPnl.Name = "pwdStrengthPnl";
            pwdStrengthPnl.Size = new Size(133, 17);
            pwdStrengthPnl.TabIndex = 22;
            // 
            // pwdGuideLbl
            // 
            pwdGuideLbl.AutoSize = true;
            pwdGuideLbl.Cursor = Cursors.Hand;
            pwdGuideLbl.Font = new Font("Tahoma", 8F, FontStyle.Underline);
            pwdGuideLbl.ForeColor = Color.Salmon;
            pwdGuideLbl.Location = new Point(679, 508);
            pwdGuideLbl.Name = "pwdGuideLbl";
            pwdGuideLbl.Size = new Size(104, 17);
            pwdGuideLbl.TabIndex = 21;
            pwdGuideLbl.Text = "Password Guide";
            pwdGuideLbl.Click += pwdGuideLbl_Click;
            // 
            // pwdTxt
            // 
            pwdTxt.BorderStyle = BorderStyle.FixedSingle;
            pwdTxt.Font = new Font("Tahoma", 10.2F);
            pwdTxt.Location = new Point(680, 476);
            pwdTxt.Multiline = true;
            pwdTxt.Name = "pwdTxt";
            pwdTxt.Size = new Size(383, 29);
            pwdTxt.TabIndex = 20;
            pwdTxt.KeyUp += pwdTxt_KeyUp;
            pwdTxt.Leave += pwdTxt_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F);
            label7.Location = new Point(680, 441);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 19;
            label7.Text = "Password";
            // 
            // countryCodeCmb
            // 
            countryCodeCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            countryCodeCmb.Font = new Font("Tahoma", 10.2F);
            countryCodeCmb.FormattingEnabled = true;
            countryCodeCmb.IntegralHeight = false;
            countryCodeCmb.Items.AddRange(new object[] { "+1", "+20", "+30", "+31", "+32", "+33", "+34", "+36", "+39", "+40", "+41", "+43", "+44", "+45", "+46", "+47", "+48", "+49", "+51", "+52", "+53", "+54", "+55", "+56", "+57", "+58", "+60", "+61", "+62", "+63", "+64", "+65", "+66", "+7", "+81", "+82", "+84", "+86", "+90", "+91", "+92", "+93", "+94", "+95", "+98", "+212", "+213", "+216", "+218", "+220", "+221", "+222", "+223", "+224", "+225", "+226", "+227", "+228", "+229", "+230", "+231", "+232", "+233", "+234", "+235", "+236", "+237", "+238", "+239", "+240", "+241", "+242", "+243", "+244", "+245", "+246", "+247", "+248", "+249", "+250", "+251", "+252", "+253", "+254", "+255", "+256", "+257", "+258", "+260", "+261", "+262", "+263", "+264", "+265", "+266", "+267", "+268", "+269", "+290", "+291", "+297", "+298", "+299", "+350", "+351", "+352", "+353", "+354", "+355", "+356", "+357", "+358", "+359", "+370", "+371", "+372", "+373", "+374", "+375", "+376", "+377", "+378", "+380", "+381", "+382", "+383", "+385", "+386", "+387", "+389", "+420", "+421", "+423", "+500", "+501", "+502", "+503", "+504", "+505", "+506", "+507", "+508", "+509", "+590", "+591", "+592", "+593", "+594", "+595", "+596", "+597", "+598", "+599", "+670", "+672", "+673", "+674", "+675", "+676", "+677", "+678", "+679", "+680", "+681", "+682", "+683", "+684", "+685", "+686", "+687", "+688", "+689", "+800", "+878", "+881", "+979" });
            countryCodeCmb.Location = new Point(680, 401);
            countryCodeCmb.Name = "countryCodeCmb";
            countryCodeCmb.Size = new Size(80, 29);
            countryCodeCmb.TabIndex = 18;
            // 
            // emailCmb
            // 
            emailCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            emailCmb.Font = new Font("Tahoma", 10.2F);
            emailCmb.FormattingEnabled = true;
            emailCmb.IntegralHeight = false;
            emailCmb.Items.AddRange(new object[] { "@gmail.com", "@hotmail.com", "@yahoo.com" });
            emailCmb.Location = new Point(930, 326);
            emailCmb.Name = "emailCmb";
            emailCmb.Size = new Size(133, 29);
            emailCmb.TabIndex = 17;
            // 
            // dobPicker
            // 
            dobPicker.CalendarFont = new Font("Tahoma", 10.2F);
            dobPicker.CustomFormat = "dd-MM-yyyy";
            dobPicker.Font = new Font("Tahoma", 10.2F);
            dobPicker.Format = DateTimePickerFormat.Custom;
            dobPicker.Location = new Point(680, 250);
            dobPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(383, 28);
            dobPicker.TabIndex = 16;
            // 
            // nationalityCmb
            // 
            nationalityCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            nationalityCmb.Font = new Font("Tahoma", 10.2F);
            nationalityCmb.FormattingEnabled = true;
            nationalityCmb.IntegralHeight = false;
            nationalityCmb.Items.AddRange(new object[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "I-Kiribati", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivian", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "New Zealander", "Ni-Vanuatu", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean" });
            nationalityCmb.Location = new Point(680, 176);
            nationalityCmb.Name = "nationalityCmb";
            nationalityCmb.Size = new Size(383, 29);
            nationalityCmb.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F);
            label2.Location = new Point(680, 366);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 14;
            label2.Text = "Phone Number";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Salmon;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ControlLightLight;
            saveBtn.Location = new Point(680, 570);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(383, 45);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "SAVE CHANGES";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F);
            label6.Location = new Point(680, 291);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // emailTxt
            // 
            emailTxt.BorderStyle = BorderStyle.FixedSingle;
            emailTxt.Font = new Font("Tahoma", 10.2F);
            emailTxt.Location = new Point(680, 326);
            emailTxt.Multiline = true;
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(250, 29);
            emailTxt.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F);
            label1.Location = new Point(680, 216);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 10;
            label1.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F);
            label4.Location = new Point(680, 141);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 5;
            label4.Text = "Nationality";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F);
            label3.Location = new Point(680, 66);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(194, 352);
            label5.Name = "label5";
            label5.Size = new Size(140, 28);
            label5.TabIndex = 6;
            label5.Text = "Edit Profile\r\n";
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
            // phoneTxt
            // 
            phoneTxt.BorderStyle = BorderStyle.FixedSingle;
            phoneTxt.Font = new Font("Tahoma", 10.2F);
            phoneTxt.Location = new Point(760, 401);
            phoneTxt.Multiline = true;
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(303, 29);
            phoneTxt.TabIndex = 13;
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
            // nameTxt
            // 
            nameTxt.BorderStyle = BorderStyle.FixedSingle;
            nameTxt.Font = new Font("Tahoma", 10.2F);
            nameTxt.Location = new Point(680, 101);
            nameTxt.Multiline = true;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(383, 29);
            nameTxt.TabIndex = 0;
            // 
            // signUpPnl
            // 
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
            signUpPnl.Controls.Add(saveBtn);
            signUpPnl.Controls.Add(label6);
            signUpPnl.Controls.Add(emailTxt);
            signUpPnl.Controls.Add(label1);
            signUpPnl.Controls.Add(label4);
            signUpPnl.Controls.Add(label3);
            signUpPnl.Controls.Add(panel2);
            signUpPnl.Controls.Add(nameTxt);
            signUpPnl.Location = new Point(0, -1);
            signUpPnl.Name = "signUpPnl";
            signUpPnl.Size = new Size(1169, 630);
            signUpPnl.TabIndex = 2;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(signUpPnl);
            Name = "EditProfile";
            Size = new Size(1169, 630);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            signUpPnl.ResumeLayout(false);
            signUpPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pwdStrengthPnl;
        private Label pwdGuideLbl;
        private TextBox pwdTxt;
        private Label label7;
        private ComboBox countryCodeCmb;
        private ComboBox emailCmb;
        private DateTimePicker dobPicker;
        private ComboBox nationalityCmb;
        private Label label2;
        private Button saveBtn;
        private Label label6;
        private TextBox emailTxt;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox phoneTxt;
        private Panel panel2;
        private TextBox nameTxt;
        private Panel signUpPnl;
    }
}
