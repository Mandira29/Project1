namespace Project1
{
    partial class shopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shopForm));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            shop_receiptBtn = new Button();
            shop_placeOrderBtn = new Button();
            shop_amount = new Label();
            label5 = new Label();
            shop_change = new TextBox();
            label3 = new Label();
            shop_total = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            prodName = new DataGridViewTextBoxColumn();
            QTY = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 661);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            flowLayoutPanel1.Location = new Point(3, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(447, 636);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(shop_receiptBtn);
            panel2.Controls.Add(shop_placeOrderBtn);
            panel2.Controls.Add(shop_amount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(shop_change);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(shop_total);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(490, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 657);
            panel2.TabIndex = 1;
            // 
            // shop_receiptBtn
            // 
            shop_receiptBtn.BackColor = Color.FromArgb(78, 52, 46);
            shop_receiptBtn.FlatAppearance.BorderSize = 0;
            shop_receiptBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            shop_receiptBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            shop_receiptBtn.FlatStyle = FlatStyle.Flat;
            shop_receiptBtn.ForeColor = Color.White;
            shop_receiptBtn.Location = new Point(4, 591);
            shop_receiptBtn.Name = "shop_receiptBtn";
            shop_receiptBtn.Size = new Size(302, 49);
            shop_receiptBtn.TabIndex = 8;
            shop_receiptBtn.Text = "RECEIPT";
            shop_receiptBtn.UseVisualStyleBackColor = false;
            shop_receiptBtn.Click += shop_receiptBtn_Click;
            // 
            // shop_placeOrderBtn
            // 
            shop_placeOrderBtn.BackColor = Color.FromArgb(78, 52, 46);
            shop_placeOrderBtn.FlatAppearance.BorderSize = 0;
            shop_placeOrderBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 130, 98);
            shop_placeOrderBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 130, 98);
            shop_placeOrderBtn.FlatStyle = FlatStyle.Flat;
            shop_placeOrderBtn.ForeColor = Color.White;
            shop_placeOrderBtn.Location = new Point(4, 506);
            shop_placeOrderBtn.Name = "shop_placeOrderBtn";
            shop_placeOrderBtn.Size = new Size(302, 49);
            shop_placeOrderBtn.TabIndex = 7;
            shop_placeOrderBtn.Text = "PLACE ORDER";
            shop_placeOrderBtn.UseVisualStyleBackColor = false;
            shop_placeOrderBtn.Click += shop_placeOrderBtn_Click;
            // 
            // shop_amount
            // 
            shop_amount.AutoSize = true;
            shop_amount.Location = new Point(94, 393);
            shop_amount.Name = "shop_amount";
            shop_amount.Size = new Size(36, 20);
            shop_amount.TabIndex = 6;
            shop_amount.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 393);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Amount";
            // 
            // shop_change
            // 
            shop_change.Location = new Point(104, 352);
            shop_change.Name = "shop_change";
            shop_change.Size = new Size(125, 27);
            shop_change.TabIndex = 4;
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 359);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Change : ";
            // 
            // shop_total
            // 
            shop_total.AutoSize = true;
            shop_total.Location = new Point(94, 323);
            shop_total.Name = "shop_total";
            shop_total.Size = new Size(36, 20);
            shop_total.TabIndex = 2;
            shop_total.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 323);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Total($)";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, prodName, QTY, Price });
            dataGridView1.Location = new Point(15, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(563, 290);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // prodName
            // 
            prodName.HeaderText = "prodName";
            prodName.MinimumWidth = 6;
            prodName.Name = "prodName";
            prodName.Width = 125;
            // 
            // QTY
            // 
            QTY.HeaderText = "QTY";
            QTY.MinimumWidth = 6;
            QTY.Name = "QTY";
            QTY.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // shopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "shopForm";
            Size = new Size(1095, 695);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button shop_placeOrderBtn;
        private Label shop_amount;
        private Label label5;
        private TextBox shop_change;
        private Label label3;
        private Label shop_total;
        private Label label1;
        private DataGridView dataGridView1;
        private Button shop_receiptBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn prodName;
        private DataGridViewTextBoxColumn QTY;
        private DataGridViewTextBoxColumn Price;
        private FlowLayoutPanel flowLayoutPanel1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
