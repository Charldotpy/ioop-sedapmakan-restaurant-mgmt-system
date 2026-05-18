namespace AdminLoadingScreen
{
    partial class SalesPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersgrid2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndate = new System.Windows.Forms.Button();
            this.btncategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usersgrid2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 638);
            this.panel1.TabIndex = 2;
            // 
            // usersgrid2
            // 
            this.usersgrid2.AllowUserToAddRows = false;
            this.usersgrid2.AllowUserToDeleteRows = false;
            this.usersgrid2.AllowUserToResizeColumns = false;
            this.usersgrid2.AllowUserToResizeRows = false;
            this.usersgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgrid2.Location = new System.Drawing.Point(26, 51);
            this.usersgrid2.Name = "usersgrid2";
            this.usersgrid2.ReadOnly = true;
            this.usersgrid2.RowHeadersVisible = false;
            this.usersgrid2.RowHeadersWidth = 82;
            this.usersgrid2.RowTemplate.Height = 33;
            this.usersgrid2.Size = new System.Drawing.Size(999, 555);
            this.usersgrid2.TabIndex = 4;
            this.usersgrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgrid2_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "SALES DATABASE";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btncategory);
            this.panel2.Controls.Add(this.btndate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(32, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 136);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIEWING DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Display";
            // 
            // btndate
            // 
            this.btndate.BackColor = System.Drawing.Color.Salmon;
            this.btndate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndate.FlatAppearance.BorderSize = 0;
            this.btndate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btndate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndate.ForeColor = System.Drawing.Color.White;
            this.btndate.Location = new System.Drawing.Point(144, 70);
            this.btndate.Name = "btndate";
            this.btndate.Size = new System.Drawing.Size(140, 48);
            this.btndate.TabIndex = 30;
            this.btndate.Text = "Date/Time";
            this.btndate.UseVisualStyleBackColor = false;
            this.btndate.Click += new System.EventHandler(this.btndate_Click);
            // 
            // btncategory
            // 
            this.btncategory.BackColor = System.Drawing.Color.Salmon;
            this.btncategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategory.FlatAppearance.BorderSize = 0;
            this.btncategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btncategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btncategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategory.ForeColor = System.Drawing.Color.White;
            this.btncategory.Location = new System.Drawing.Point(312, 70);
            this.btncategory.Name = "btncategory";
            this.btncategory.Size = new System.Drawing.Size(140, 48);
            this.btncategory.TabIndex = 31;
            this.btncategory.Text = "Category";
            this.btncategory.UseVisualStyleBackColor = false;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // SalesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SalesPanel";
            this.Size = new System.Drawing.Size(1117, 857);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView usersgrid2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.Button btndate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
