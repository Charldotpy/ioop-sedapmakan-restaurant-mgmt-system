namespace showmembers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nextbn = new Button();
            backbtn = new Button();
            mainPnl = new Panel();
            SuspendLayout();
            // 
            // nextbn
            // 
            nextbn.BackColor = Color.Salmon;
            nextbn.Cursor = Cursors.Hand;
            nextbn.Font = new Font("Tahoma", 9F);
            nextbn.ForeColor = SystemColors.ControlLightLight;
            nextbn.Location = new Point(1027, 636);
            nextbn.Name = "nextbn";
            nextbn.Size = new Size(120, 45);
            nextbn.TabIndex = 8;
            nextbn.Text = "Forward >";
            nextbn.UseVisualStyleBackColor = false;
            nextbn.Click += nextbn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.Salmon;
            backbtn.Cursor = Cursors.Hand;
            backbtn.Font = new Font("Tahoma", 9F);
            backbtn.ForeColor = SystemColors.ControlLightLight;
            backbtn.Location = new Point(5, 635);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(120, 45);
            backbtn.TabIndex = 9;
            backbtn.Text = "< Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // mainPnl
            // 
            mainPnl.Location = new Point(-9, 0);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(1169, 630);
            mainPnl.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1151, 685);
            Controls.Add(backbtn);
            Controls.Add(nextbn);
            Controls.Add(mainPnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "SedapMakan Kitchen Management System";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button nextbn;
        private Button backbtn;
        private Panel mainPnl;
    }
}
