namespace Project1
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            close = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            logout_btn = new Button();
            customers_btn = new Button();
            shop_btn = new Button();
            categories_btn = new Button();
            inventry_btn = new Button();
            dashbpard_btn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            shopForm1 = new shopForm();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.ImageAlign = ContentAlignment.TopRight;
            close.Location = new Point(1482, 3);
            close.Name = "close";
            close.Size = new Size(59, 40);
            close.TabIndex = 0;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(close, 0, 0);
            tableLayoutPanel1.Location = new Point(-105, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1544, 790);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(109, 76, 65);
            panel1.Controls.Add(logout_btn);
            panel1.Controls.Add(customers_btn);
            panel1.Controls.Add(shop_btn);
            panel1.Controls.Add(categories_btn);
            panel1.Controls.Add(inventry_btn);
            panel1.Controls.Add(dashbpard_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 723);
            panel1.TabIndex = 3;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(78, 52, 46);
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(3, 657);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(269, 53);
            logout_btn.TabIndex = 7;
            logout_btn.Text = "LogOut";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += button6_Click;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.FromArgb(78, 52, 46);
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            customers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(3, 468);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(269, 53);
            customers_btn.TabIndex = 6;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += customers_btn_Click;
            // 
            // shop_btn
            // 
            shop_btn.BackColor = Color.FromArgb(78, 52, 46);
            shop_btn.FlatAppearance.BorderSize = 0;
            shop_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            shop_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            shop_btn.FlatStyle = FlatStyle.Flat;
            shop_btn.ForeColor = Color.White;
            shop_btn.Location = new Point(3, 256);
            shop_btn.Name = "shop_btn";
            shop_btn.Size = new Size(269, 53);
            shop_btn.TabIndex = 5;
            shop_btn.Text = "Shop";
            shop_btn.UseVisualStyleBackColor = false;
            shop_btn.Click += shop_btn_Click;
            // 
            // categories_btn
            // 
            categories_btn.BackColor = Color.FromArgb(78, 52, 46);
            categories_btn.FlatAppearance.BorderSize = 0;
            categories_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            categories_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            categories_btn.FlatStyle = FlatStyle.Flat;
            categories_btn.ForeColor = Color.White;
            categories_btn.Location = new Point(3, 398);
            categories_btn.Name = "categories_btn";
            categories_btn.Size = new Size(269, 53);
            categories_btn.TabIndex = 4;
            categories_btn.Text = "Categories";
            categories_btn.UseVisualStyleBackColor = false;
            categories_btn.Click += categories_btn_Click;
            // 
            // inventry_btn
            // 
            inventry_btn.BackColor = Color.FromArgb(78, 52, 46);
            inventry_btn.FlatAppearance.BorderSize = 0;
            inventry_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            inventry_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            inventry_btn.FlatStyle = FlatStyle.Flat;
            inventry_btn.ForeColor = Color.White;
            inventry_btn.Location = new Point(3, 328);
            inventry_btn.Name = "inventry_btn";
            inventry_btn.Size = new Size(269, 53);
            inventry_btn.TabIndex = 3;
            inventry_btn.Text = "Inventry";
            inventry_btn.UseVisualStyleBackColor = false;
            inventry_btn.Click += inventry_btn_Click;
            // 
            // dashbpard_btn
            // 
            dashbpard_btn.BackColor = Color.FromArgb(78, 52, 46);
            dashbpard_btn.FlatAppearance.BorderSize = 0;
            dashbpard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            dashbpard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            dashbpard_btn.FlatStyle = FlatStyle.Flat;
            dashbpard_btn.ForeColor = Color.White;
            dashbpard_btn.Location = new Point(3, 184);
            dashbpard_btn.Name = "dashbpard_btn";
            dashbpard_btn.Size = new Size(269, 53);
            dashbpard_btn.TabIndex = 2;
            dashbpard_btn.Text = "Dashboard";
            dashbpard_btn.UseVisualStyleBackColor = false;
            dashbpard_btn.Click += dashbpard_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 144);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 1;
            label1.Text = "Welcome, Admin !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 4;
            label2.Text = "Resturant Management System";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 817);
            panel2.Name = "panel2";
            panel2.Size = new Size(1442, 10);
            panel2.TabIndex = 5;
            // 
            // shopForm1
            // 
            shopForm1.Location = new Point(293, 46);
            shopForm1.Name = "shopForm1";
            shopForm1.Size = new Size(1145, 723);
            shopForm1.TabIndex = 7;
            shopForm1.Visible = false;
            shopForm1.Load += shopForm1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 827);
            Controls.Add(shopForm1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected internal Button close;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button dashbpard_btn;
        private Button logout_btn;
        private Button customers_btn;
        private Button shop_btn;
        private Button categories_btn;
        private Button inventry_btn;
        private Label label2;
        private Panel panel2;
        private dashboardForm dashboardForm1;
        private shopForm shopForm1;
        private inventryForm inventryForm1;
        private categoriesForm categoriesForm1;
        private customersForm customersForm1;
    }
}