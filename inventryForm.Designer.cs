namespace Project1
{
    partial class inventryForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            inventry_clearBtn = new Button();
            inventry_updateBtn = new Button();
            inventry_deleteBtn = new Button();
            inventry_addBtn = new Button();
            inventry_importBtn = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            inventry_status = new ComboBox();
            inventry_price = new TextBox();
            inventry_stock = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            inventry_category = new ComboBox();
            inventry_productName = new TextBox();
            inventry_productID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 430);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(78, 52, 46);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1118, 336);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "All Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(inventry_clearBtn);
            panel2.Controls.Add(inventry_updateBtn);
            panel2.Controls.Add(inventry_deleteBtn);
            panel2.Controls.Add(inventry_addBtn);
            panel2.Controls.Add(inventry_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(inventry_status);
            panel2.Controls.Add(inventry_price);
            panel2.Controls.Add(inventry_stock);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(inventry_category);
            panel2.Controls.Add(inventry_productName);
            panel2.Controls.Add(inventry_productID);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(1141, 283);
            panel2.TabIndex = 1;
            // 
            // inventry_clearBtn
            // 
            inventry_clearBtn.BackColor = Color.FromArgb(78, 52, 46);
            inventry_clearBtn.FlatAppearance.BorderSize = 0;
            inventry_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            inventry_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            inventry_clearBtn.FlatStyle = FlatStyle.Flat;
            inventry_clearBtn.ForeColor = Color.White;
            inventry_clearBtn.Location = new Point(725, 220);
            inventry_clearBtn.Name = "inventry_clearBtn";
            inventry_clearBtn.Size = new Size(149, 35);
            inventry_clearBtn.TabIndex = 17;
            inventry_clearBtn.Text = "CLEAR";
            inventry_clearBtn.UseVisualStyleBackColor = false;
            inventry_clearBtn.Click += inventry_clearBtn_Click;
            // 
            // inventry_updateBtn
            // 
            inventry_updateBtn.BackColor = Color.FromArgb(78, 52, 46);
            inventry_updateBtn.FlatAppearance.BorderSize = 0;
            inventry_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            inventry_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            inventry_updateBtn.FlatStyle = FlatStyle.Flat;
            inventry_updateBtn.ForeColor = Color.White;
            inventry_updateBtn.Location = new Point(273, 220);
            inventry_updateBtn.Name = "inventry_updateBtn";
            inventry_updateBtn.Size = new Size(149, 35);
            inventry_updateBtn.TabIndex = 16;
            inventry_updateBtn.Text = "UPDATE";
            inventry_updateBtn.UseVisualStyleBackColor = false;
            inventry_updateBtn.Click += inventry_updateBtn_Click;
            // 
            // inventry_deleteBtn
            // 
            inventry_deleteBtn.BackColor = Color.FromArgb(78, 52, 46);
            inventry_deleteBtn.FlatAppearance.BorderSize = 0;
            inventry_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            inventry_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            inventry_deleteBtn.FlatStyle = FlatStyle.Flat;
            inventry_deleteBtn.ForeColor = Color.White;
            inventry_deleteBtn.Location = new Point(530, 220);
            inventry_deleteBtn.Name = "inventry_deleteBtn";
            inventry_deleteBtn.Size = new Size(149, 35);
            inventry_deleteBtn.TabIndex = 15;
            inventry_deleteBtn.Text = "DELETE";
            inventry_deleteBtn.UseVisualStyleBackColor = false;
            inventry_deleteBtn.Click += inventry_deleteBtn_Click;
            // 
            // inventry_addBtn
            // 
            inventry_addBtn.BackColor = Color.FromArgb(78, 52, 46);
            inventry_addBtn.FlatAppearance.BorderSize = 0;
            inventry_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            inventry_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            inventry_addBtn.FlatStyle = FlatStyle.Flat;
            inventry_addBtn.ForeColor = Color.White;
            inventry_addBtn.Location = new Point(36, 220);
            inventry_addBtn.Name = "inventry_addBtn";
            inventry_addBtn.Size = new Size(149, 35);
            inventry_addBtn.TabIndex = 14;
            inventry_addBtn.Text = "ADD";
            inventry_addBtn.UseVisualStyleBackColor = false;
            inventry_addBtn.Click += inventry_addBtn_Click;
            // 
            // inventry_importBtn
            // 
            inventry_importBtn.BackColor = Color.FromArgb(78, 52, 46);
            inventry_importBtn.FlatAppearance.BorderSize = 0;
            inventry_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            inventry_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            inventry_importBtn.FlatStyle = FlatStyle.Flat;
            inventry_importBtn.ForeColor = Color.White;
            inventry_importBtn.Location = new Point(937, 220);
            inventry_importBtn.Name = "inventry_importBtn";
            inventry_importBtn.Size = new Size(149, 35);
            inventry_importBtn.TabIndex = 13;
            inventry_importBtn.Text = "IMPORT";
            inventry_importBtn.UseVisualStyleBackColor = false;
            inventry_importBtn.Click += inventry_importBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(937, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(149, 167);
            panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // inventry_status
            // 
            inventry_status.FormattingEnabled = true;
            inventry_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            inventry_status.Location = new Point(576, 164);
            inventry_status.Name = "inventry_status";
            inventry_status.Size = new Size(256, 28);
            inventry_status.TabIndex = 11;
            // 
            // inventry_price
            // 
            inventry_price.Location = new Point(576, 118);
            inventry_price.Name = "inventry_price";
            inventry_price.Size = new Size(256, 27);
            inventry_price.TabIndex = 10;
            // 
            // inventry_stock
            // 
            inventry_stock.Location = new Point(576, 73);
            inventry_stock.Name = "inventry_stock";
            inventry_stock.Size = new Size(256, 27);
            inventry_stock.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 172);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 125);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 7;
            label6.Text = "Price ($)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(501, 80);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 6;
            label7.Text = "Stock";
            // 
            // inventry_category
            // 
            inventry_category.FormattingEnabled = true;
            inventry_category.Location = new Point(157, 164);
            inventry_category.Name = "inventry_category";
            inventry_category.Size = new Size(285, 28);
            inventry_category.TabIndex = 5;
            // 
            // inventry_productName
            // 
            inventry_productName.Location = new Point(157, 118);
            inventry_productName.Name = "inventry_productName";
            inventry_productName.Size = new Size(285, 27);
            inventry_productName.TabIndex = 4;
            // 
            // inventry_productID
            // 
            inventry_productID.Location = new Point(157, 73);
            inventry_productID.Name = "inventry_productID";
            inventry_productID.Size = new Size(285, 27);
            inventry_productID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 172);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 125);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 1;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Product ID";
            // 
            // inventryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "inventryForm";
            Size = new Size(1157, 753);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private ComboBox inventry_status;
        private TextBox inventry_price;
        private TextBox inventry_stock;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox inventry_category;
        private TextBox inventry_productName;
        private TextBox inventry_productID;
        private Label label4;
        private Button inventry_importBtn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button inventry_clearBtn;
        private Button inventry_updateBtn;
        private Button inventry_deleteBtn;
        private Button inventry_addBtn;
        private DataGridView dataGridView1;
    }
}
