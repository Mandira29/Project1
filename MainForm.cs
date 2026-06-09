// you need to debug the customerForm loading when it is loading

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class MainForm : Form

    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashbpard_btn_Click(object sender, EventArgs e)
        {
            // show dashboard and hide others
            dashboardForm1.Visible = true;
            dashboardForm1.BringToFront();
            shopForm1.Visible = false;
            inventryForm1.Visible = false;
            categoriesForm1.Visible = false;
        }

        private void inventry_btn_Click(object sender, EventArgs e)
        {
            // show inventry and hide others
            inventryForm1.Visible = true;
            inventryForm1.BringToFront();
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            categoriesForm1.Visible = false;
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            shopForm1.Visible = true;
            shopForm1.BringToFront();
            dashboardForm1.Visible = false;
            inventryForm1.Visible = false;
            categoriesForm1.Visible = false;
        }

        private void categories_btn_Click(object sender, EventArgs e)
        {
            categoriesForm1.Visible = true;
            categoriesForm1.BringToFront();
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventryForm1.Visible = false;
        }


        private void customers_btn_Click(object sender, EventArgs e)
        {
            customersForm1.Visible = true;
            customersForm1.BringToFront();
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventryForm1.Visible = false;

        }

        private void shopForm1_Load(object sender, EventArgs e)
        {

        }
    }

}
