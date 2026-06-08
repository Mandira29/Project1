using System;
using System.Collections.Generic;
// ADD THIS: Required for SQL Server classes
using Microsoft.Data.SqlClient;

namespace Project1
{
    internal class customersList
    {
        // Note: Check if "resturantsystem" is spelled correctly in your actual DB (usually "restaurant")
        private readonly string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=resturantsystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public int id { get; set; }
        public string CustomerId { get; set; }
        public string productsIds { get; set; }
        public string quantities { get; set; }
        public string prices { get; set; }
        public string totalPrice { get; set; }
        public string dateOrder { get; set; }


        public List<customersList> customersListData()
        {
            List<customersList> listData = new List<customersList>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string selectData = "SELECT * FROM orders";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customersList cData = new customersList
                        {
                            id = (int)reader["id"],
                            CustomerId = reader["CustomerId"].ToString(),
                            productsIds = reader["product_ids"].ToString(),
                            quantities = reader["quantities"].ToString(),
                            prices = reader["prices"].ToString(),
                            totalPrice = reader["total"].ToString(),
                            dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy")
                        };
                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }

        public List<customersList> todaysSalescustomerListData()
        {
            List<customersList> listData = new List<customersList>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string selectData = "SELECT * FROM orders where date_order = @date";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Now;
                    string getToday = today.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@date", getToday);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customersList cData = new customersList
                        {
                            id = (int)reader["id"],
                            CustomerId = reader["CustomerId"].ToString(),
                            productsIds = reader["product_ids"].ToString(),
                            quantities = reader["quantities"].ToString(),
                            prices = reader["prices"].ToString(),
                            totalPrice = reader["total"].ToString(),
                            dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy")
                        };
                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
