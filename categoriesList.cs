using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    internal class categoriesList
    {
        string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=resturantsystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public int id { get; set; }
        public string category { get; set; }

        public string status { get; set; }

        public string date_created { get; set; }


        public List<categoriesList> categoreiesListData()
        {
            List<categoriesList> listData = new List<categoriesList>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            categoriesList cData = new categoriesList();
                            {
                                cData.id = (int)reader["id"];
                                cData.category = reader["category"].ToString();
                                cData.status = reader["status"].ToString();
                                cData.date_created = ((DateTime)reader["date_created"]).ToString("MM-dd-yyyy");

                                listData.Add(cData);


                            }
                        }
                    }
                }
            }
            return listData;
        }

    }
}

