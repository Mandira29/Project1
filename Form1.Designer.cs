namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            close = new Button();
            pictureBox1 = new PictureBox();
            login_btn = new Button();
            login_showPassword = new CheckBox();
            login_password = new TextBox();
            login_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(close, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(343, 48);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.ImageAlign = ContentAlignment.TopRight;
            close.Location = new Point(281, 3);
            close.Name = "close";
            close.Size = new Size(59, 42);
            close.TabIndex = 0;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 100);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(78, 65, 46);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(109, 76, 65);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(10, 399);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(319, 49);
            login_btn.TabIndex = 19;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_showPassword
            // 
            login_showPassword.AutoSize = true;
            login_showPassword.Location = new Point(11, 358);
            login_showPassword.Name = "login_showPassword";
            login_showPassword.Size = new Size(132, 24);
            login_showPassword.TabIndex = 18;
            login_showPassword.Text = "Show Password";
            login_showPassword.UseVisualStyleBackColor = true;
            // 
            // login_password
            // 
            login_password.Location = new Point(11, 315);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(318, 27);
            login_password.TabIndex = 17;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // login_username
            // 
            login_username.Location = new Point(8, 232);
            login_username.Name = "login_username";
            login_username.Size = new Size(318, 27);
            login_username.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 463);
            label4.Name = "label4";
            label4.Size = new Size(207, 20);
            label4.TabIndex = 15;
            label4.Text = "No account yet? Register here";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 198);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 14;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 278);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 13;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 157);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 12;
            label1.Text = "Welcome Back!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 621);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(login_btn);
            Controls.Add(login_showPassword);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        protected internal Button close;
        private PictureBox pictureBox1;
        private Button login_btn;
        private CheckBox login_showPassword;
        private TextBox login_password;
        private TextBox login_username;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
