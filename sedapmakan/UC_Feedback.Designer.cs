namespace _123
{
    partial class UC_Feedback
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Button buttonSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelFeedback = new Label();
            textBoxFeedback = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // labelFeedback
            // 
            labelFeedback.AutoSize = true;
            labelFeedback.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFeedback.ForeColor = SystemColors.ControlLightLight;
            labelFeedback.Location = new Point(20, 20);
            labelFeedback.Name = "labelFeedback";
            labelFeedback.Size = new Size(333, 41);
            labelFeedback.TabIndex = 0;
            labelFeedback.Text = "Enter your feedback:";
            // 
            // textBoxFeedback
            // 
            textBoxFeedback.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFeedback.Location = new Point(20, 72);
            textBoxFeedback.Multiline = true;
            textBoxFeedback.Name = "textBoxFeedback";
            textBoxFeedback.Size = new Size(500, 190);
            textBoxFeedback.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(20, 268);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(100, 30);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // UC_Feedback
            // 
            BackColor = Color.Salmon;
            Controls.Add(labelFeedback);
            Controls.Add(textBoxFeedback);
            Controls.Add(buttonSubmit);
            Name = "UC_Feedback";
            Size = new Size(1169, 630);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}