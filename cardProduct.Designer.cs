namespace Project1
{
    partial class cardProduct
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            productname = new Label();
            price = new Label();
            label3 = new Label();
            stock = new Label();
            quantity = new TextBox();
            add_btn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 143);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.trevenue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 143);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // productname
            // 
            productname.AutoSize = true;
            productname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productname.Location = new Point(3, 159);
            productname.Name = "productname";
            productname.Size = new Size(110, 20);
            productname.TabIndex = 1;
            productname.Text = "Product Name";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(6, 179);
            price.Name = "price";
            price.Size = new Size(44, 20);
            price.TabIndex = 2;
            price.Text = "$0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 209);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Stock :";
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(63, 209);
            stock.Name = "stock";
            stock.Size = new Size(17, 20);
            stock.TabIndex = 4;
            stock.Text = "0";
            // 
            // quantity
            // 
            quantity.Location = new Point(63, 247);
            quantity.Name = "quantity";
            quantity.Size = new Size(71, 27);
            quantity.TabIndex = 5;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(78, 52, 46);
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            add_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(140, 245);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(63, 31);
            add_btn.TabIndex = 6;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 250);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 7;
            label5.Text = "QTY";
            // 
            // cardProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label5);
            Controls.Add(add_btn);
            Controls.Add(quantity);
            Controls.Add(stock);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(productname);
            Controls.Add(panel1);
            Name = "cardProduct";
            Size = new Size(207, 306);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label productname;
        private Label price;
        private Label label3;
        private Label stock;
        private TextBox quantity;
        private Button add_btn;
        private Label label5;
    }
}
