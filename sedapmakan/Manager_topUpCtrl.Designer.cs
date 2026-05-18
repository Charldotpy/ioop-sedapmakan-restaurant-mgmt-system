namespace Manager
{
    partial class Manager_topUpCtrl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            topUpTbl = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            selectBtn = new Button();
            userIdTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            topUpTxt = new TextBox();
            label3 = new Label();
            topUpBtn = new Button();
            managerRb = new RadioButton();
            refundRb = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)topUpTbl).BeginInit();
            SuspendLayout();
            // 
            // topUpTbl
            // 
            topUpTbl.AllowUserToAddRows = false;
            topUpTbl.BackgroundColor = SystemColors.Control;
            topUpTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            topUpTbl.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            topUpTbl.DefaultCellStyle = dataGridViewCellStyle1;
            topUpTbl.GridColor = Color.Salmon;
            topUpTbl.Location = new Point(334, 279);
            topUpTbl.Margin = new Padding(3, 4, 3, 4);
            topUpTbl.Name = "topUpTbl";
            topUpTbl.RowHeadersWidth = 51;
            topUpTbl.RowTemplate.Height = 24;
            topUpTbl.Size = new Size(500, 312);
            topUpTbl.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 40;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "Amount";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Method";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            // 
            // selectBtn
            // 
            selectBtn.BackColor = Color.Salmon;
            selectBtn.Cursor = Cursors.Hand;
            selectBtn.Font = new Font("Tahoma", 10.2F);
            selectBtn.ForeColor = SystemColors.ControlLightLight;
            selectBtn.Location = new Point(724, 129);
            selectBtn.Margin = new Padding(3, 4, 3, 4);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(110, 36);
            selectBtn.TabIndex = 9;
            selectBtn.Text = "Select";
            selectBtn.UseVisualStyleBackColor = false;
            selectBtn.Click += selectBtn_Click;
            // 
            // userIdTxt
            // 
            userIdTxt.Font = new Font("Tahoma", 10.2F);
            userIdTxt.Location = new Point(602, 134);
            userIdTxt.Margin = new Padding(3, 4, 3, 4);
            userIdTxt.Name = "userIdTxt";
            userIdTxt.Size = new Size(110, 28);
            userIdTxt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(334, 138);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 6;
            label1.Text = "User ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(334, 178);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 10;
            label2.Text = "Top-up Amount :";
            // 
            // topUpTxt
            // 
            topUpTxt.Font = new Font("Tahoma", 10.2F);
            topUpTxt.Location = new Point(602, 175);
            topUpTxt.Margin = new Padding(3, 4, 3, 4);
            topUpTxt.Name = "topUpTxt";
            topUpTxt.ReadOnly = true;
            topUpTxt.Size = new Size(110, 28);
            topUpTxt.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(566, 179);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 12;
            label3.Text = "RM";
            // 
            // topUpBtn
            // 
            topUpBtn.BackColor = Color.Salmon;
            topUpBtn.Cursor = Cursors.Hand;
            topUpBtn.Enabled = false;
            topUpBtn.Font = new Font("Tahoma", 10.2F);
            topUpBtn.ForeColor = SystemColors.ControlLightLight;
            topUpBtn.Location = new Point(724, 170);
            topUpBtn.Margin = new Padding(3, 4, 3, 4);
            topUpBtn.Name = "topUpBtn";
            topUpBtn.Size = new Size(110, 36);
            topUpBtn.TabIndex = 13;
            topUpBtn.Text = "Top Up";
            topUpBtn.UseVisualStyleBackColor = false;
            topUpBtn.Click += topUpBtn_Click;
            // 
            // managerRb
            // 
            managerRb.AutoSize = true;
            managerRb.Font = new Font("Tahoma", 9F);
            managerRb.ForeColor = SystemColors.ControlLightLight;
            managerRb.Location = new Point(602, 219);
            managerRb.Margin = new Padding(3, 4, 3, 4);
            managerRb.Name = "managerRb";
            managerRb.Size = new Size(159, 22);
            managerRb.TabIndex = 0;
            managerRb.TabStop = true;
            managerRb.Text = "Manager Assistance";
            managerRb.UseVisualStyleBackColor = true;
            // 
            // refundRb
            // 
            refundRb.AutoSize = true;
            refundRb.Font = new Font("Tahoma", 9F);
            refundRb.ForeColor = SystemColors.ControlLightLight;
            refundRb.Location = new Point(763, 219);
            refundRb.Margin = new Padding(3, 4, 3, 4);
            refundRb.Name = "refundRb";
            refundRb.Size = new Size(75, 22);
            refundRb.TabIndex = 1;
            refundRb.TabStop = true;
            refundRb.Text = "Refund";
            refundRb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Salmon;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(436, 50);
            label4.Name = "label4";
            label4.Size = new Size(297, 41);
            label4.TabIndex = 14;
            label4.Text = "TOP-UP MANAGER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(334, 219);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 15;
            label5.Text = "Method :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(539, 138);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 16;
            label6.Text = "SEDAP";
            // 
            // Manager_topUpCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(refundRb);
            Controls.Add(managerRb);
            Controls.Add(topUpBtn);
            Controls.Add(label3);
            Controls.Add(topUpTxt);
            Controls.Add(label2);
            Controls.Add(selectBtn);
            Controls.Add(userIdTxt);
            Controls.Add(label1);
            Controls.Add(topUpTbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_topUpCtrl";
            Size = new Size(1169, 630);
            Load += topUpCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)topUpTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView topUpTbl;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox topUpTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button topUpBtn;
        private System.Windows.Forms.RadioButton managerRb;
        private System.Windows.Forms.RadioButton refundRb;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
