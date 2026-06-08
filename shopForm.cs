using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project1
{
    public partial class shopForm : UserControl
    {
        string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=resturantsystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private bool check;

        public shopForm()
        {
            InitializeComponent();
            // Defer loading products to runtime only so the designer can instantiate this control without connecting to the database.
            this.Load += shopForm_Load;
        }

        private void shopForm_Load(object? sender, EventArgs e)
        {
            // At design time, DesignMode may not be reliable inside the constructor, so additionally check LicenseManager.
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                loadProducts();
            }
        }

        public void cardItems(int id, string productName, string stock, string price, Image image, string productId, string category, string quantity)
        {
            var card = new cardProduct()
            {
                id = id,
                productId = productId,
                productName = productName,
                productStock = stock,
                productPrice = price,
                productImage = image,
                Category = category,
                productQuantity = quantity,
            };

            flowLayoutPanel1.Controls.Add(card);

            card.selectedCard += (q, w) =>
            {
                var selectedCard = (cardProduct)q;
                bool flag = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Try to read the ID cell using the column name used in the grid (case-sensitive).
                    object cellVal = null;
                    if (dataGridView1.Columns.Contains("ID")) cellVal = row.Cells["ID"]?.Value;
                    else if (dataGridView1.Columns.Contains("id")) cellVal = row.Cells["id"]?.Value;

                    if (cellVal != null && int.TryParse(cellVal.ToString(), out int existingId) && existingId == selectedCard.id)
                    {
                        decimal getPrice = Convert.ToDecimal(selectedCard.productPrice.Replace("$", "")); // Remove $ if present and convert to decimal)
                        int getQuantity = Convert.ToInt32(selectedCard.productQuantity);

                        row.Cells["Price"].Value = getPrice;
                        row.Cells["Qty"].Value = getQuantity;



                        if (dataGridView1.Columns.Contains("ProdName"))
                            row.Cells["ProdName"].Value = selectedCard.productName;

                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    // Add a new row with quantity = 1 (use numeric value for QTY column)
                    decimal getPrice = Convert.ToDecimal(selectedCard.productPrice.Replace("$", ""));
                    int getQuantity = Convert.ToInt32(selectedCard.productQuantity);
                    // Remove $ if present and convert to decimal)
                    dataGridView1.Rows.Add(selectedCard.id, selectedCard.productName, getQuantity, getQuantity * getPrice);
                }
                updateTotalPrice();
            };
        }

        public void updateTotalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    total += price;
                }
            }
            shop_total.Text = $"Total: ${total:0.00}";
        }

        public void loadProducts()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string selectData = "SELECT * FROM products where status = 'Available' ";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        flowLayoutPanel1.Controls.Clear();

                        foreach (DataRow row in table.Rows)
                        {
                            int id = row["id"] != DBNull.Value ? (int)row["id"] : 0;
                            string productid = row["product_id"] != DBNull.Value ? row["product_id"].ToString() : "N/A";
                            string productname = row["product_name"] != DBNull.Value ? row["product_name"].ToString() : "N/A";
                            string stock = row["stock"] != DBNull.Value ? row["stock"].ToString() : "0";
                            string price = row["price"] != DBNull.Value ? $"${row["price"].ToString()}.00" : "0.00";

                            string category = table.Columns.Contains("category_id") && row["category_id"] != DBNull.Value ? row["category_id"].ToString() : "N/A";
                            string quantity = table.Columns.Contains("quantity") && row["quantity"] != DBNull.Value ? row["quantity"].ToString() : "0";

                            Image image = null;

                            if (table.Columns.Contains("image") && row["image"] != DBNull.Value)
                            {
                                string imagePath = row["image"].ToString();
                                if (File.Exists(imagePath))
                                {
                                    try
                                    {
                                        image = Image.FromFile(imagePath);
                                    }
                                    catch
                                    {
                                        image = null;
                                    }
                                }
                            }

                            cardItems(id, productname, stock, price, image, productid, category, quantity);
                        }



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void shop_change_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    decimal getTotal = Convert.ToDecimal(shop_total.Text.ToString().Replace("Total: $", ""));
                    decimal getChange = Convert.ToDecimal(shop_change.Text);

                    if (getTotal > getChange)
                    {
                        MessageBox.Show("Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        shop_change.Text = "";
                    }

                    else
                    {
                        check = false;

                        shop_amount.Text = $"${getChange - getTotal:0.00}";
                    }
                    e.SuppressKeyPress = true; // Prevent the ding sound on Enter key

                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void shop_placeOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Direct validation without needing the 'check' variable
                decimal totalAmount = Convert.ToDecimal(shop_total.Text.ToString().Replace("Total: $", ""));

                if (string.IsNullOrEmpty(shop_change.Text) || !decimal.TryParse(shop_change.Text, out decimal getChange))
                {
                    MessageBox.Show("Please enter a valid payment amount.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (totalAmount > getChange)
                {
                    MessageBox.Show("Invalid : Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Automatically update the change/amount display
                shop_amount.Text = $"${getChange - totalAmount:0.00}";

                // 3. Confirm and process order
                if (MessageBox.Show("Are you sure you want to place the order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        int count = 1;
                        string countData = "SELECT COUNT(*) FROM orders";

                        using (SqlCommand cData = new SqlCommand(countData, connect))
                        {
                            count = Convert.ToInt32(cData.ExecuteScalar());
                        }

                        List<string> productIds = new List<string>();
                        List<string> quantities = new List<string>();
                        List<string> prices = new List<string>();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["id"].Value != null && row.Cells["QTY"].Value != null && row.Cells["price"].Value != null)
                            {
                                productIds.Add(row.Cells["id"].Value.ToString());
                                quantities.Add(row.Cells["QTY"].Value.ToString());
                                prices.Add(row.Cells["price"].Value.ToString());
                            }

                            string productIdsStr = string.Join(",", productIds);
                            string quantitiesStr = string.Join(",", quantities);
                            string pricesStr = string.Join(",", prices);

                            string insertData = "INSERT INTO orders (customerId, product_ids, quantities, prices, total, date_order) VALUES (@cid, @pid, @qty, @price, @total, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cid", $"CID-{count}");
                                cmd.Parameters.AddWithValue("@pid", productIdsStr);
                                cmd.Parameters.AddWithValue("@qty", quantitiesStr);
                                cmd.Parameters.AddWithValue("@price", pricesStr);
                                cmd.Parameters.AddWithValue("@total", totalAmount);

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                int rowAffected = cmd.ExecuteNonQuery();

                                if (rowAffected > 0)
                                {
                                    for (int q = 0; q < productIds.Count; q++)
                                    {
                                        string getStockData = "SELECT stock FROM products WHERE id = @id";
                                        int currentstock = 0;

                                        using (SqlCommand getSD = new SqlCommand(getStockData, connect))
                                        {
                                            getSD.Parameters.AddWithValue("@id", productIds[q]);
                                            object result = getSD.ExecuteScalar();
                                            if (result != null)
                                            {
                                                currentstock = Convert.ToInt32(result);
                                            }
                                        }

                                        int newStock = currentstock - Convert.ToInt32(quantities[q]);
                                        if (currentstock > 0)
                                        {
                                            MessageBox.Show($"Current stock for product ID {productIds[q]}: {currentstock}. New stock after order: {newStock}", "Stock Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }


                                        string updateData = "UPDATE products SET stock = stock - @qty WHERE id = @id";
                                        using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                                        {
                                            updateCmd.Parameters.AddWithValue("@qty", quantities[q]);
                                            updateCmd.Parameters.AddWithValue("@id", productIds[q]);
                                            updateCmd.ExecuteNonQuery();
                                        }
                                    }

                                    MessageBox.Show("Order placed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to place the order.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Catches conversion errors, text formatting mismatches, or database connectivity issues safely
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int rowIndex = 0;
        private void shop_receiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font labelFont = new Font("Arial", 10, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "SURA Resturant";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView1.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            string header = "PID".PadRight(20) + "ProductName".PadRight(20) + "Category".PadRight(20) + "Qty".PadRight(10) + "Price".PadRight(10);

            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q].ToString(), bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                for (int q = 0; q < dataGridView1.Columns.Count; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }

                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

            }

            int labelMargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString($"Total Price: \t${shop_total.Text.Trim()}\n\t\t--------------\nChange:\t${shop_amount.Text.Trim()}", labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("-------------------", labelFont).Width, y);

        }

        
    }
}