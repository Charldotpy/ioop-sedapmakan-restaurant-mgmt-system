namespace Manager
{
    partial class Manager_fbBlock
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
            nameLbl = new Label();
            dateLbl = new Label();
            feedbackLbl = new Label();
            replyTxt = new TextBox();
            replyBtn = new Button();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = SystemColors.ControlText;
            nameLbl.Location = new Point(9, 8);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(76, 22);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "nameLbl";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLbl.ForeColor = SystemColors.ControlDark;
            dateLbl.Location = new Point(10, 34);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(54, 18);
            dateLbl.TabIndex = 1;
            dateLbl.Text = "dateLbl";
            // 
            // feedbackLbl
            // 
            feedbackLbl.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackLbl.ForeColor = SystemColors.ControlText;
            feedbackLbl.Location = new Point(9, 62);
            feedbackLbl.Name = "feedbackLbl";
            feedbackLbl.Size = new Size(525, 31);
            feedbackLbl.TabIndex = 2;
            feedbackLbl.Text = "feedbackLbl";
            feedbackLbl.Click += feedbackLbl_Click;
            // 
            // replyTxt
            // 
            replyTxt.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            replyTxt.Location = new Point(9, 106);
            replyTxt.Margin = new Padding(3, 4, 3, 4);
            replyTxt.Name = "replyTxt";
            replyTxt.Size = new Size(432, 28);
            replyTxt.TabIndex = 3;
            // 
            // replyBtn
            // 
            replyBtn.BackColor = SystemColors.ControlLightLight;
            replyBtn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            replyBtn.ForeColor = SystemColors.ControlText;
            replyBtn.Location = new Point(444, 103);
            replyBtn.Margin = new Padding(3, 4, 3, 4);
            replyBtn.Name = "replyBtn";
            replyBtn.Size = new Size(90, 32);
            replyBtn.TabIndex = 4;
            replyBtn.Text = "Reply";
            replyBtn.UseVisualStyleBackColor = false;
            replyBtn.Click += replyBtn_Click;
            // 
            // Manager_fbBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(replyBtn);
            Controls.Add(replyTxt);
            Controls.Add(feedbackLbl);
            Controls.Add(dateLbl);
            Controls.Add(nameLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_fbBlock";
            Size = new Size(542, 145);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label feedbackLbl;
        private System.Windows.Forms.TextBox replyTxt;
        private System.Windows.Forms.Button replyBtn;
    }
}
