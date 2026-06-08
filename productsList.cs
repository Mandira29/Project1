using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Project1
{
    internal class productsList
    {
        string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=resturantsystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string stock { get; set; }
        public string price { get; set; }
        public string status { get; set; }
        public string image { get; set; }
        public string dateCreated { get; set; }
        public string dateUpdated { get; set; }


        public List<productsList> productListData()
        {
            List<productsList> listData = new List<productsList>();
            string selectData = @"SELECT id,product_id,product_name, category_id, stock, price, status, image,date_created, date_updated
              FROM products";

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productsList pList = new productsList();

                            pList.ID = (int)reader["id"];
                            pList.ProductID = reader["product_id"].ToString();
                            pList.ProductName = reader["product_name"].ToString();
                            pList.Category = reader["category_id"].ToString();
                            pList.stock = reader["stock"].ToString();
                            pList.price = reader["price"].ToString();
                            pList.status = reader["status"].ToString();
                            pList.image = reader["image"].ToString();
                            pList.dateCreated = ((DateTime)reader["date_created"]).ToString("MM-dd-yyyy");
                            pList.dateUpdated = reader["date_updated"] == DBNull.Value ? null : ((DateTime)reader["date_updated"]).ToString("MM-dd-yyyy");

                            listData.Add(pList);
                        }
                    }
                }
            }
            return listData;
        }
    }
}
