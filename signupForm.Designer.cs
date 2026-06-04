namespace Project1
{
    partial class signupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupForm));
            signup_confirmPassword = new TextBox();
            label5 = new Label();
            signup_btn = new Button();
            signup_showPassword = new CheckBox();
            signup_password = new TextBox();
            signup_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            close = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signup_confirmPassword
            // 
            signup_confirmPassword.Location = new Point(-3, 370);
            signup_confirmPassword.Name = "signup_confirmPassword";
            signup_confirmPassword.Size = new Size(318, 27);
            signup_confirmPassword.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 347);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 32;
            label5.Text = "Confirm Password";
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(78, 65, 46);
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(109, 76, 65);
            signup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(-4, 463);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(319, 49);
            signup_btn.TabIndex = 31;
            signup_btn.Text = "REGISTER";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_showPassword
            // 
            signup_showPassword.AutoSize = true;
            signup_showPassword.Location = new Point(-3, 418);
            signup_showPassword.Name = "signup_showPassword";
            signup_showPassword.Size = new Size(132, 24);
            signup_showPassword.TabIndex = 30;
            signup_showPassword.Text = "Show Password";
            signup_showPassword.UseVisualStyleBackColor = true;
            signup_showPassword.CheckedChanged += signup_showPassword_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(-3, 307);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(318, 27);
            signup_password.TabIndex = 29;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(-3, 238);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(318, 27);
            signup_username.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 529);
            label4.Name = "label4";
            label4.Size = new Size(263, 20);
            label4.TabIndex = 27;
            label4.Text = "Already Have an account? Sign in here";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-4, 215);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 26;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 284);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 25;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 182);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 24;
            label1.Text = "Hello new user !";
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
            tableLayoutPanel1.Size = new Size(325, 48);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.ImageAlign = ContentAlignment.TopRight;
            close.Location = new Point(263, 3);
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
            pictureBox1.Location = new Point(111, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 100);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // signupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 574);
            Controls.Add(signup_confirmPassword);
            Controls.Add(label5);
            Controls.Add(signup_btn);
            Controls.Add(signup_showPassword);
            Controls.Add(signup_password);
            Controls.Add(signup_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signupForm";
            Text = "signupForm";
            Load += signupForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox signup_confirmPassword;
        private Label label5;
        private Button signup_btn;
        private CheckBox signup_showPassword;
        private TextBox signup_password;
        private TextBox signup_username;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        protected internal Button close;
        private PictureBox pictureBox1;
    }
}