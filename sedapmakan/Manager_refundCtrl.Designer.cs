namespace Manager
{
    partial class Manager_refundCtrl
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
            filterBtn = new Button();
            refundPnl = new FlowLayoutPanel();
            userIdTxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // filterBtn
            // 
            filterBtn.BackColor = Color.Salmon;
            filterBtn.Cursor = Cursors.Hand;
            filterBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBtn.ForeColor = SystemColors.ControlLightLight;
            filterBtn.Location = new Point(644, 11);
            filterBtn.Margin = new Padding(3, 4, 3, 4);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(110, 36);
            filterBtn.TabIndex = 11;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
            // 
            // refundPnl
            // 
            refundPnl.AutoScroll = true;
            refundPnl.Location = new Point(29, 54);
            refundPnl.Margin = new Padding(3, 4, 3, 4);
            refundPnl.Name = "refundPnl";
            refundPnl.Size = new Size(1110, 551);
            refundPnl.TabIndex = 10;
            // 
            // userIdTxt
            // 
            userIdTxt.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userIdTxt.Location = new Point(498, 15);
            userIdTxt.Margin = new Padding(3, 4, 3, 4);
            userIdTxt.Name = "userIdTxt";
            userIdTxt.Size = new Size(140, 28);
            userIdTxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(414, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 6;
            label1.Text = "User ID :";
            // 
            // Manager_refundCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(filterBtn);
            Controls.Add(refundPnl);
            Controls.Add(userIdTxt);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_refundCtrl";
            Size = new Size(1169, 630);
            Load += refundCtrl_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.FlowLayoutPanel refundPnl;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.Label label1;
    }
}
