namespace showmembers
{
    partial class mainmenu
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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(150, 127);
            button1.Name = "button1";
            button1.Size = new Size(223, 53);
            button1.TabIndex = 0;
            button1.Text = "1. Edit Menu Items";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 192);
            button2.Name = "button2";
            button2.Size = new Size(223, 53);
            button2.TabIndex = 1;
            button2.Text = "2. Add New Menu Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(150, 255);
            button4.Name = "button4";
            button4.Size = new Size(223, 53);
            button4.TabIndex = 3;
            button4.Text = "3. View Orders";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(150, 387);
            button5.Name = "button5";
            button5.Size = new Size(223, 53);
            button5.TabIndex = 4;
            button5.Text = "5. Update profile";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(150, 321);
            button6.Name = "button6";
            button6.Size = new Size(223, 53);
            button6.TabIndex = 5;
            button6.Text = "4. Update Order Progress";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(660, 395);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 7;
            label1.Text = "Chef Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_06_09_195637_removebg_preview;
            pictureBox1.Location = new Point(635, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // mainmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "mainmenu";
            Size = new Size(976, 567);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
