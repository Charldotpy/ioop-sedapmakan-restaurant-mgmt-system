namespace AdminLoadingScreen
{
    partial class Wallet
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
            this.usersgrid3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usersgrid3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 787);
            this.panel1.TabIndex = 4;
            // 
            // usersgrid3
            // 
            this.usersgrid3.AllowUserToAddRows = false;
            this.usersgrid3.AllowUserToDeleteRows = false;
            this.usersgrid3.AllowUserToResizeColumns = false;
            this.usersgrid3.AllowUserToResizeRows = false;
            this.usersgrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgrid3.Location = new System.Drawing.Point(26, 51);
            this.usersgrid3.Name = "usersgrid3";
            this.usersgrid3.ReadOnly = true;
            this.usersgrid3.RowHeadersVisible = false;
            this.usersgrid3.RowHeadersWidth = 82;
            this.usersgrid3.RowTemplate.Height = 33;
            this.usersgrid3.Size = new System.Drawing.Size(999, 704);
            this.usersgrid3.TabIndex = 4;
            this.usersgrid3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgrid3_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = " E WALLET DATABASE";
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Wallet";
            this.Size = new System.Drawing.Size(1117, 857);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView usersgrid3;
        private System.Windows.Forms.Label label3;
    }
}
