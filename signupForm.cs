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
    public partial class signupForm : Form
    {
        string connection = @"Data Source =.\SQLEXPRESS; Initial Catalog = resturantsystem; Integrated Security = True; Trust Server Certificate=True";

        public signupForm()
        {
            InitializeComponent();
        }

        private void signupForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void signup_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPassword.Checked ? '\0' : '*';
            signup_confirmPassword.PasswordChar = signup_showPassword.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string checkUsern = "select * from users where username = @usern";

                using (SqlCommand checkUsersn = new SqlCommand(checkUsern, connect))
                {
                    checkUsersn.Parameters.AddWithValue("@usern", signup_username.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsersn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show($"{signup_username.Text.Trim()}was taken already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (signup_password.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Invalid Password , at least 8 characters required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (signup_password.Text.Trim() != signup_confirmPassword.Text.Trim())
                    {
                        MessageBox.Show("Paassword does not match", "Error Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertDate = "insert into users (username,password,status,date_created) VALUES(@usern, @pass,@status,@date)";

                        using (SqlCommand cmd = new SqlCommand(insertDate, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 loginForm = new Form1();
                            loginForm.Show();

                            this.Hide();
                        }
                    }
                }

            }
        }
    }
}
