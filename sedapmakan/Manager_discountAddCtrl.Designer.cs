namespace Manager
{
    partial class Manager_discountAddCtrl
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
            typeGrp = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            valueGrp = new GroupBox();
            valueUpDown = new NumericUpDown();
            label1 = new Label();
            fixedRb = new RadioButton();
            percentageRb = new RadioButton();
            codeGrp = new GroupBox();
            codeTxt = new TextBox();
            label2 = new Label();
            createBtn = new Button();
            typeGrp.SuspendLayout();
            valueGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valueUpDown).BeginInit();
            codeGrp.SuspendLayout();
            SuspendLayout();
            // 
            // typeGrp
            // 
            typeGrp.Controls.Add(radioButton2);
            typeGrp.Controls.Add(radioButton1);
            typeGrp.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeGrp.Location = new Point(192, 25);
            typeGrp.Margin = new Padding(3, 4, 3, 4);
            typeGrp.Name = "typeGrp";
            typeGrp.Padding = new Padding(3, 4, 3, 4);
            typeGrp.Size = new Size(500, 88);
            typeGrp.TabIndex = 8;
            typeGrp.TabStop = false;
            typeGrp.Text = "SELECT DISCOUNT TYPE";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Tahoma", 9F);
            radioButton2.Location = new Point(150, 37);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 22);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Storewide";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Tahoma", 9F);
            radioButton1.Location = new Point(21, 37);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 22);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Whole Order";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // valueGrp
            // 
            valueGrp.Controls.Add(valueUpDown);
            valueGrp.Controls.Add(label1);
            valueGrp.Controls.Add(fixedRb);
            valueGrp.Controls.Add(percentageRb);
            valueGrp.Enabled = false;
            valueGrp.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valueGrp.Location = new Point(192, 125);
            valueGrp.Margin = new Padding(3, 4, 3, 4);
            valueGrp.Name = "valueGrp";
            valueGrp.Padding = new Padding(3, 4, 3, 4);
            valueGrp.Size = new Size(500, 112);
            valueGrp.TabIndex = 9;
            valueGrp.TabStop = false;
            valueGrp.Text = "ENTER DISCOUNT VALUE";
            // 
            // valueUpDown
            // 
            valueUpDown.Font = new Font("Tahoma", 9F);
            valueUpDown.Location = new Point(100, 72);
            valueUpDown.Margin = new Padding(3, 4, 3, 4);
            valueUpDown.Name = "valueUpDown";
            valueUpDown.Size = new Size(140, 26);
            valueUpDown.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(6, 75);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 2;
            label1.Text = "Enter value : ";
            // 
            // fixedRb
            // 
            fixedRb.AutoSize = true;
            fixedRb.Font = new Font("Tahoma", 9F);
            fixedRb.Location = new Point(150, 32);
            fixedRb.Margin = new Padding(3, 4, 3, 4);
            fixedRb.Name = "fixedRb";
            fixedRb.Size = new Size(63, 22);
            fixedRb.TabIndex = 1;
            fixedRb.TabStop = true;
            fixedRb.Text = "Fixed";
            fixedRb.UseVisualStyleBackColor = true;
            // 
            // percentageRb
            // 
            percentageRb.AutoSize = true;
            percentageRb.Font = new Font("Tahoma", 9F);
            percentageRb.Location = new Point(21, 32);
            percentageRb.Margin = new Padding(3, 4, 3, 4);
            percentageRb.Name = "percentageRb";
            percentageRb.Size = new Size(102, 22);
            percentageRb.TabIndex = 0;
            percentageRb.TabStop = true;
            percentageRb.Text = "Percentage";
            percentageRb.UseVisualStyleBackColor = true;
            // 
            // codeGrp
            // 
            codeGrp.Controls.Add(codeTxt);
            codeGrp.Controls.Add(label2);
            codeGrp.Enabled = false;
            codeGrp.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            codeGrp.Location = new Point(192, 250);
            codeGrp.Margin = new Padding(3, 4, 3, 4);
            codeGrp.Name = "codeGrp";
            codeGrp.Padding = new Padding(3, 4, 3, 4);
            codeGrp.Size = new Size(500, 88);
            codeGrp.TabIndex = 10;
            codeGrp.TabStop = false;
            codeGrp.Text = "ENTER DISCOUNT CODE";
            // 
            // codeTxt
            // 
            codeTxt.Font = new Font("Tahoma", 9F);
            codeTxt.Location = new Point(100, 35);
            codeTxt.Margin = new Padding(3, 4, 3, 4);
            codeTxt.Name = "codeTxt";
            codeTxt.Size = new Size(140, 26);
            codeTxt.TabIndex = 0;
            codeTxt.KeyPress += codeTxt_KeyPress;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(117, 29);
            label2.TabIndex = 0;
            label2.Text = "Enter code : ";
            // 
            // createBtn
            // 
            createBtn.Enabled = false;
            createBtn.Font = new Font("Tahoma", 9F);
            createBtn.Location = new Point(372, 410);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(140, 50);
            createBtn.TabIndex = 12;
            createBtn.Text = "Create Discount";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // Manager_discountAddCtrl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createBtn);
            Controls.Add(codeGrp);
            Controls.Add(valueGrp);
            Controls.Add(typeGrp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_discountAddCtrl";
            Size = new Size(885, 610);
            typeGrp.ResumeLayout(false);
            typeGrp.PerformLayout();
            valueGrp.ResumeLayout(false);
            valueGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)valueUpDown).EndInit();
            codeGrp.ResumeLayout(false);
            codeGrp.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox typeGrp;
        private System.Windows.Forms.GroupBox valueGrp;
        private System.Windows.Forms.GroupBox codeGrp;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown valueUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fixedRb;
        private System.Windows.Forms.RadioButton percentageRb;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
