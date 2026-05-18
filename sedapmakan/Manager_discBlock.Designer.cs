namespace Manager
{
    partial class Manager_discBlock
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
            label2 = new Label();
            codeGrp = new GroupBox();
            codeTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            discountLbl = new Label();
            typeLbl = new Label();
            deleteBtn = new Button();
            saveBtn = new Button();
            activateChk = new CheckBox();
            percentageRb = new RadioButton();
            fixedRb = new RadioButton();
            label1 = new Label();
            valueUpDown = new NumericUpDown();
            valueGrp = new GroupBox();
            codeGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valueUpDown).BeginInit();
            valueGrp.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(162, 29);
            label2.TabIndex = 7;
            label2.Text = "Discount ID : ";
            // 
            // codeGrp
            // 
            codeGrp.BackColor = Color.White;
            codeGrp.Controls.Add(codeTxt);
            codeGrp.Controls.Add(label3);
            codeGrp.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeGrp.Location = new Point(9, 195);
            codeGrp.Margin = new Padding(3, 4, 3, 4);
            codeGrp.Name = "codeGrp";
            codeGrp.Padding = new Padding(3, 4, 3, 4);
            codeGrp.Size = new Size(240, 88);
            codeGrp.TabIndex = 11;
            codeGrp.TabStop = false;
            codeGrp.Text = "ENTER DISCOUNT CODE";
            // 
            // codeTxt
            // 
            codeTxt.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeTxt.Location = new Point(100, 35);
            codeTxt.Margin = new Padding(3, 4, 3, 4);
            codeTxt.Name = "codeTxt";
            codeTxt.Size = new Size(134, 22);
            codeTxt.TabIndex = 0;
            codeTxt.KeyPress += codeTxt_KeyPress;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 39);
            label3.Name = "label3";
            label3.Size = new Size(84, 29);
            label3.TabIndex = 0;
            label3.Text = "Enter code : ";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 42);
            label4.Name = "label4";
            label4.Size = new Size(162, 29);
            label4.TabIndex = 12;
            label4.Text = "Discount type : ";
            // 
            // discountLbl
            // 
            discountLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountLbl.Location = new Point(106, 14);
            discountLbl.Name = "discountLbl";
            discountLbl.Size = new Size(162, 29);
            discountLbl.TabIndex = 13;
            discountLbl.Text = "discountLbl";
            // 
            // typeLbl
            // 
            typeLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeLbl.Location = new Point(106, 42);
            typeLbl.Name = "typeLbl";
            typeLbl.Size = new Size(162, 29);
            typeLbl.TabIndex = 14;
            typeLbl.Text = "typeLbl";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(141, 335);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(110, 34);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(9, 335);
            saveBtn.Margin = new Padding(3, 4, 3, 4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(110, 34);
            saveBtn.TabIndex = 15;
            saveBtn.Text = "Save Changes";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // activateChk
            // 
            activateChk.AutoSize = true;
            activateChk.Location = new Point(9, 298);
            activateChk.Margin = new Padding(3, 4, 3, 4);
            activateChk.Name = "activateChk";
            activateChk.Size = new Size(147, 24);
            activateChk.TabIndex = 17;
            activateChk.Text = "Activate Discount";
            activateChk.UseVisualStyleBackColor = true;
            activateChk.CheckedChanged += activateChk_CheckedChanged;
            // 
            // percentageRb
            // 
            percentageRb.AutoSize = true;
            percentageRb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percentageRb.Location = new Point(21, 32);
            percentageRb.Margin = new Padding(3, 4, 3, 4);
            percentageRb.Name = "percentageRb";
            percentageRb.Size = new Size(98, 20);
            percentageRb.TabIndex = 0;
            percentageRb.TabStop = true;
            percentageRb.Text = "Percentage";
            percentageRb.UseVisualStyleBackColor = true;
            // 
            // fixedRb
            // 
            fixedRb.AutoSize = true;
            fixedRb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fixedRb.Location = new Point(132, 32);
            fixedRb.Margin = new Padding(3, 4, 3, 4);
            fixedRb.Name = "fixedRb";
            fixedRb.Size = new Size(61, 20);
            fixedRb.TabIndex = 1;
            fixedRb.TabStop = true;
            fixedRb.Text = "Fixed";
            fixedRb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 75);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 2;
            label1.Text = "Enter value : ";
            // 
            // valueUpDown
            // 
            valueUpDown.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valueUpDown.Location = new Point(100, 72);
            valueUpDown.Margin = new Padding(3, 4, 3, 4);
            valueUpDown.Name = "valueUpDown";
            valueUpDown.Size = new Size(134, 22);
            valueUpDown.TabIndex = 6;
            // 
            // valueGrp
            // 
            valueGrp.BackColor = Color.White;
            valueGrp.Controls.Add(valueUpDown);
            valueGrp.Controls.Add(label1);
            valueGrp.Controls.Add(fixedRb);
            valueGrp.Controls.Add(percentageRb);
            valueGrp.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valueGrp.Location = new Point(9, 75);
            valueGrp.Margin = new Padding(3, 4, 3, 4);
            valueGrp.Name = "valueGrp";
            valueGrp.Padding = new Padding(3, 4, 3, 4);
            valueGrp.Size = new Size(240, 112);
            valueGrp.TabIndex = 10;
            valueGrp.TabStop = false;
            valueGrp.Text = "CHANGE DISCOUNT VALUE";
            // 
            // Manager_discBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(activateChk);
            Controls.Add(deleteBtn);
            Controls.Add(saveBtn);
            Controls.Add(typeLbl);
            Controls.Add(discountLbl);
            Controls.Add(label4);
            Controls.Add(codeGrp);
            Controls.Add(label2);
            Controls.Add(valueGrp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_discBlock";
            Size = new Size(257, 380);
            codeGrp.ResumeLayout(false);
            codeGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)valueUpDown).EndInit();
            valueGrp.ResumeLayout(false);
            valueGrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox codeGrp;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox activateChk;
        private RadioButton percentageRb;
        private RadioButton fixedRb;
        private Label label1;
        private NumericUpDown valueUpDown;
        private GroupBox valueGrp;
    }
}
