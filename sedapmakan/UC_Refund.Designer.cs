namespace _123
{
    partial class UC_Refund
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            comboBoxOrders = new ComboBox();
            textBoxReason = new TextBox();
            labelReason = new Label();
            buttonRequestRefund = new Button();
            dataGridViewRefunds = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRefunds).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(527, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Request Refund / Cancel Order";
            // 
            // comboBoxOrders
            // 
            comboBoxOrders.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrders.Location = new Point(20, 73);
            comboBoxOrders.Name = "comboBoxOrders";
            comboBoxOrders.Size = new Size(400, 28);
            comboBoxOrders.TabIndex = 1;
            // 
            // textBoxReason
            // 
            textBoxReason.Location = new Point(20, 143);
            textBoxReason.Name = "textBoxReason";
            textBoxReason.Size = new Size(400, 27);
            textBoxReason.TabIndex = 3;
            // 
            // labelReason
            // 
            labelReason.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReason.ForeColor = SystemColors.ControlLightLight;
            labelReason.Location = new Point(20, 113);
            labelReason.Name = "labelReason";
            labelReason.Size = new Size(290, 27);
            labelReason.TabIndex = 2;
            labelReason.Text = "Reason for Refund:";
            // 
            // buttonRequestRefund
            // 
            buttonRequestRefund.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRequestRefund.ForeColor = SystemColors.ControlLightLight;
            buttonRequestRefund.Location = new Point(20, 183);
            buttonRequestRefund.Name = "buttonRequestRefund";
            buttonRequestRefund.Size = new Size(170, 40);
            buttonRequestRefund.TabIndex = 4;
            buttonRequestRefund.Text = "Request Refund";
            buttonRequestRefund.Click += buttonRequestRefund_Click;
            // 
            // dataGridViewRefunds
            // 
            dataGridViewRefunds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRefunds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRefunds.Location = new Point(20, 240);
            dataGridViewRefunds.Name = "dataGridViewRefunds";
            dataGridViewRefunds.RowHeadersWidth = 51;
            dataGridViewRefunds.Size = new Size(750, 370);
            dataGridViewRefunds.TabIndex = 5;
            // 
            // UC_Refund
            // 
            BackColor = Color.Salmon;
            Controls.Add(labelTitle);
            Controls.Add(comboBoxOrders);
            Controls.Add(labelReason);
            Controls.Add(textBoxReason);
            Controls.Add(buttonRequestRefund);
            Controls.Add(dataGridViewRefunds);
            Name = "UC_Refund";
            Size = new Size(1169, 630);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRefunds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Button buttonRequestRefund;
        private System.Windows.Forms.DataGridView dataGridViewRefunds;
    }
}