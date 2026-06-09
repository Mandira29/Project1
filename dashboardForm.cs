using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project1
{
    public partial class dashboardForm : UserControl
    {
        string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=resturantsystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public dashboardForm()
        {
            InitializeComponent();
            displayTotalProducts();
            displayTotalUsers();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayTodaySales();
        }

        public void displayTodaySales()
        {
            customersList cData = new customersList();
            List<customersList> todaysSales = new customersList().todaysSalescustomerListData();
        }
        public void displayTotalUsers()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string selectData = "SELECT COUNT(*) FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_totalUsers.Text = count.ToString();

                    }
                }


            }
        }

        public void displayTotalProducts()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string selectData = "SELECT COUNT(id) FROM products";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_totalProducts.Text = count.ToString();
                    }
                }
            }
        }

        public void displayTodaysRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string selectData = "SELECT SUM(CAST(total AS DECIMAL(10,2))) FROM orders where date_order = @date";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Now;
                    string getToday = today.ToString("yyyy-MM-dd");


                    cmd.Parameters.AddWithValue("@date", getToday);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader[0] != DBNull.Value)
                        {
                            decimal count = Convert.ToDecimal(reader[0]);
                            dashboard_todaysRevenue.Text = "$" + count.ToString("0.00");
                        }
                        else
                        {
                            dashboard_todaysRevenue.Text = "$0.00";
                        }
                    }
                }
            }
        }

        public void displayTotalRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string selectData = "SELECT SUM(CAST(total AS DECIMAL(10,2))) FROM orders ";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                  
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader[0] != DBNull.Value)
                        {
                            decimal count = Convert.ToDecimal(reader[0]);
                            dashboard_totalRevenue.Text = "$" + count.ToString("0.00");
                        }
                        else
                        {
                            dashboard_totalRevenue.Text = "$0.00";
                        }
                    }
                }
            }
        }


    }
}