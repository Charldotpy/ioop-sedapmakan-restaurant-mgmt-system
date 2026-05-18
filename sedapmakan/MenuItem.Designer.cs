namespace showmembers
{
    partial class MenuItem
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
            pictureBoxItem = new PictureBox();
            lblPrice = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            lblQuantity = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Location = new Point(4, 2);
            pictureBoxItem.Margin = new Padding(3, 2, 3, 2);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new Size(239, 125);
            pictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxItem.TabIndex = 0;
            pictureBoxItem.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(4, 157);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price: ";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(149, 174);
            btnPlus.Margin = new Padding(3, 2, 3, 2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(31, 22);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += button1_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(52, 174);
            btnMinus.Margin = new Padding(3, 2, 3, 2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(31, 22);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += button2_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(108, 177);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(13, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "0";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(4, 136);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblName);
            Controls.Add(lblQuantity);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(lblPrice);
            Controls.Add(pictureBoxItem);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuItem";
            Size = new Size(246, 198);
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxItem;
        private Label lblPrice;
        private Button btnPlus;
        private Button btnMinus;
        private Label lblQuantity;
        private Label lblName;
    }
}
