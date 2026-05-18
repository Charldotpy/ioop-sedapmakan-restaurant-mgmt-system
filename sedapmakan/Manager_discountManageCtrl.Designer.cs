namespace Manager
{
    partial class Manager_discountManageCtrl
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
            discountPnl = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // discountPnl
            // 
            discountPnl.AutoScroll = true;
            discountPnl.Location = new Point(3, 4);
            discountPnl.Margin = new Padding(3, 4, 3, 4);
            discountPnl.Name = "discountPnl";
            discountPnl.Size = new Size(879, 602);
            discountPnl.TabIndex = 6;
            // 
            // Manager_discountManageCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discountPnl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_discountManageCtrl";
            Size = new Size(885, 610);
            Load += discountManageCtrl_Load;
            ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel discountPnl;
    }
}
