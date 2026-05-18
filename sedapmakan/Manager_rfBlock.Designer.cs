namespace Manager
{
    partial class Manager_rfBlock
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
            confirmBtn = new Button();
            refundLbl = new Label();
            dateLbl = new Label();
            nameLbl = new Label();
            rejectRb = new RadioButton();
            approveRb = new RadioButton();
            replyTxt = new TextBox();
            SuspendLayout();
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = SystemColors.ControlLightLight;
            confirmBtn.Font = new Font("Tahoma", 9F);
            confirmBtn.ForeColor = SystemColors.ControlText;
            confirmBtn.Location = new Point(445, 128);
            confirmBtn.Margin = new Padding(3, 4, 3, 4);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(90, 32);
            confirmBtn.TabIndex = 9;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // refundLbl
            // 
            refundLbl.Font = new Font("Tahoma", 12F);
            refundLbl.ForeColor = SystemColors.ControlText;
            refundLbl.Location = new Point(9, 62);
            refundLbl.Name = "refundLbl";
            refundLbl.Size = new Size(525, 31);
            refundLbl.TabIndex = 7;
            refundLbl.Text = "refundLbl";
            refundLbl.Click += refundLbl_Click;
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Font = new Font("Tahoma", 9F);
            dateLbl.ForeColor = SystemColors.ControlDark;
            dateLbl.Location = new Point(10, 34);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(54, 18);
            dateLbl.TabIndex = 6;
            dateLbl.Text = "dateLbl";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Tahoma", 10.8F);
            nameLbl.ForeColor = SystemColors.ControlText;
            nameLbl.Location = new Point(9, 8);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(76, 22);
            nameLbl.TabIndex = 5;
            nameLbl.Text = "nameLbl";
            // 
            // rejectRb
            // 
            rejectRb.AutoSize = true;
            rejectRb.Font = new Font("Tahoma", 9F);
            rejectRb.ForeColor = SystemColors.ControlText;
            rejectRb.Location = new Point(122, 104);
            rejectRb.Margin = new Padding(3, 4, 3, 4);
            rejectRb.Name = "rejectRb";
            rejectRb.Size = new Size(70, 22);
            rejectRb.TabIndex = 11;
            rejectRb.TabStop = true;
            rejectRb.Text = "Reject";
            rejectRb.UseVisualStyleBackColor = true;
            // 
            // approveRb
            // 
            approveRb.AutoSize = true;
            approveRb.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            approveRb.ForeColor = SystemColors.ControlText;
            approveRb.Location = new Point(11, 104);
            approveRb.Margin = new Padding(3, 4, 3, 4);
            approveRb.Name = "approveRb";
            approveRb.Size = new Size(83, 22);
            approveRb.TabIndex = 10;
            approveRb.TabStop = true;
            approveRb.Text = "Approve";
            approveRb.UseVisualStyleBackColor = true;
            // 
            // replyTxt
            // 
            replyTxt.Font = new Font("Tahoma", 10.2F);
            replyTxt.Location = new Point(9, 130);
            replyTxt.Margin = new Padding(3, 4, 3, 4);
            replyTxt.Name = "replyTxt";
            replyTxt.Size = new Size(432, 28);
            replyTxt.TabIndex = 12;
            // 
            // Manager_rfBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(replyTxt);
            Controls.Add(rejectRb);
            Controls.Add(approveRb);
            Controls.Add(confirmBtn);
            Controls.Add(refundLbl);
            Controls.Add(dateLbl);
            Controls.Add(nameLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_rfBlock";
            Size = new Size(542, 170);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label refundLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.RadioButton rejectRb;
        private System.Windows.Forms.RadioButton approveRb;
        private TextBox replyTxt;
    }
}
