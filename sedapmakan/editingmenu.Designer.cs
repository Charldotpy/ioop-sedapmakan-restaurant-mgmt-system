namespace showmembers
{
    partial class editingmenu
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
            lblName = new Label();
            lblPrice = new Label();
            pictureBoxItem = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(9, 185);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 11;
            lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(9, 218);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price: ";
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Location = new Point(9, 6);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new Size(273, 167);
            pictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxItem.TabIndex = 6;
            pictureBoxItem.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 14;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 24);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "available";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 24);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "out of stock";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(9, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 102);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Availability";
            // 
            // editingmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Controls.Add(pictureBoxItem);
            Name = "editingmenu";
            Size = new Size(290, 376);
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPrice;
        private PictureBox pictureBoxItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
    }
}
