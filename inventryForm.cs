using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.IO;

namespace Project1
{
    public partial class inventryForm : UserControl
    {
        string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=resturantsystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public inventryForm()
        {
            InitializeComponent();
            displayCategories();
        }

        public void displayProducts()
        {
            productsList pList = new productsList();

            List<productsList> listData = pList.productListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategories()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string selectData = "SELECT * FROM categories where status = 'Active'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        inventry_category.Items.Add(reader["category"]);
                    }
                }
            }
            displayProducts();
        }

        private void inventry_addBtn_Click(object sender, EventArgs e)
        {
            if (inventry_productID.Text == "" || inventry_productName.Text == "" || inventry_category.SelectedIndex == -1
                || inventry_price.Text == "" || inventry_stock.Text == "" || inventry_status.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string checkProductID = "SELECT * FROM products WHERE product_id = @prodid";

                    using (SqlCommand checkProdId = new SqlCommand(checkProductID, connect))
                    {
                        checkProdId.Parameters.AddWithValue("@prodid", inventry_productID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkProdId);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show(inventry_productID.Text.Trim() + " is exiting already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else
                        {
                            // continue to add product
                            string basedDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            const string insertData = "INSERT INTO products(product_id, product_name, category_id,stock, price, status,image,date_created)" +
                                "VALUES(@product_id, @product_name, @category_id, @stock, @price, @status, @image,@date)";

                            string relativePath = Path.Combine("products_directory", inventry_productID.Text.Trim() + ".jpg");
                            string path = Path.Combine(basedDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@product_id", inventry_productID.Text.Trim());
                                cmd.Parameters.AddWithValue("@product_name", inventry_productName.Text.Trim());
                                cmd.Parameters.AddWithValue("@category_id", inventry_category.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(inventry_stock.Text.Trim()));
                                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(inventry_price.Text.Trim()));
                                cmd.Parameters.AddWithValue("@status", inventry_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", relativePath);

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Product added successfully", "Informatin Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }

                    }
                }
            }
        }

        private void inventry_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void clearFields()
        {
            inventry_productID.Clear();
            inventry_productName.Clear();
            inventry_category.SelectedIndex = -1;
            inventry_price.Clear();
            inventry_stock.Clear();
            inventry_status.SelectedIndex = -1;
            pictureBox1.ImageLocation = null;
            getID = 0;
        }

        private void inventry_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                inventry_productID.Text = row.Cells[1].Value.ToString();
                inventry_productName.Text = row.Cells[2].Value.ToString();
                inventry_category.Text = row.Cells[3].Value.ToString();
                inventry_stock.Text = row.Cells[4].Value.ToString();
                inventry_price.Text = row.Cells[5].Value.ToString();
                inventry_status.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error : {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void inventry_updateBtn_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string checkProductId = "Select * from products where checkProductId=@product_id";

                    using (SqlCommand checkProd = new SqlCommand(checkProductId, connect))
                    {
                        checkProd.Parameters.AddWithValue("@product_id", inventry_productID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkProd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count >= 2)
                        {
                            MessageBox.Show(inventry_productID.Text.Trim() + " is exiting already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string updateData = "UPDATE products SET product_id=@product_id, product_name=@product_name, category_id=@category_id," +
                                 " stock=@stock, price=@price, status=@status, date_updated=@date_updated WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@product_id", inventry_productID.Text.Trim());
                                cmd.Parameters.AddWithValue("@product_name", inventry_productName.Text.Trim());
                                cmd.Parameters.AddWithValue("@category_id", inventry_category.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(inventry_stock.Text.Trim()));
                                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(inventry_price.Text.Trim()));
                                cmd.Parameters.AddWithValue("@status", inventry_status.Text.Trim());

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date_updated", today);
                                cmd.Parameters.AddWithValue("@id", getID);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Product updated successfully", "Informatin Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                                displayProducts();
                            }
                        }
                    }
                }

            }
        }

        private void inventry_deleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure you want to delete this ID : {getID} ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getID == 0 )
                {
                    MessageBox.Show("Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM products WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product deleted successfully", "Informatin Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                            displayProducts();
                        }
                    }
                }
            }
        }
    }
}
