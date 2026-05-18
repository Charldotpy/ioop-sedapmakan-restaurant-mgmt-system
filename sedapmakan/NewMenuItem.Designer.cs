namespace showmembers
{
    partial class NewMenuItem
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnSave = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(739, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Tahoma", 10.2F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(773, 338);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 1;
            button1.Text = "Upload Image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(284, 122);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 2;
            label1.Text = "Enter the Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(284, 169);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 3;
            label2.Text = "Enter The Price";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 10.2F);
            textBox1.Location = new Point(489, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 28);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 10.2F);
            textBox2.Location = new Point(489, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 28);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Main Course", "Appetizer", "Beverage", "Dessert" });
            comboBox1.Location = new Point(489, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 29);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(284, 220);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 7;
            label3.Text = "Choose Category";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Tahoma", 10.2F);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(284, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 135);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Available Yet ? ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(225, 79);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(129, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Not Available";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(225, 46);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Available";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Salmon;
            btnSave.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(574, 466);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 43);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save New Item";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(401, 40);
            label4.Name = "label4";
            label4.Size = new Size(367, 41);
            label4.TabIndex = 10;
            label4.Text = "Create New Menu Item";
            // 
            // NewMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "NewMenuItem";
            Size = new Size(1169, 630);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnSave;
        private Label label4;
    }
}
