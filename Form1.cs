//using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Project1
{
    public partial class Form1 : Form
    {
        //database connection string

        string connection = @"Data Source =.\SQLEXPRESS; Initial Catalog = resturantsystem; Integrated Security = True; Trust Server Certificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to close this app ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query = "SELECT * FROM users WHERE username=@usern AND password=@pass";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    cmd.Parameters.AddWithValue("@usern", login_username.Text);
                    cmd.Parameters.AddWithValue("@pass", login_password.Text);


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully!",
                            "Information Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        /* MainForm mainForm = new MainForm();
                         mainForm.Show();

                         this.Hide();*/
                    }

                    else
                    {
                        MessageBox.Show("Incorrect Username or Password",
                        "Error Message",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            signupForm signupForm = new signupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
