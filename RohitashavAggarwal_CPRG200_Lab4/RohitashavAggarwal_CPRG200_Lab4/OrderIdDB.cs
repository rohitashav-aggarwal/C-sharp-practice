/*
 * @Author: Rohitashav Aggarwal
 * @Date: 22 January 2020
 * @Purpose: Retrieve/Update orders for a particular OrderID and display statistics
 * @Class: CPRG-200 lab 4 - OOSD Program - SAIT
*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohitashavAggarwal_CPRG200_Lab4
{
    // order id database class to extract order id's from the database using sql
    public static class OrderIdDB
    {
        public static List<OrderId> GetOrderIds()
        {
            // empty list to store the retrieved values from database
            List<OrderId> ids = new List<OrderId>();
            OrderId id;
            // create connection
            using (SqlConnection connection = NorthwindCon.GetConnection())
            {
                // select query
                string query = "SELECT orderid FROM orders";
                              
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // run the command and process results
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            // process next record from data reader
                            id = new OrderId();
                            id.orderId = (int)reader["orderid"];
                            ids.Add(id);
                        }
                    }// closes reader and recycles object
                }// cmd object recycled
            }// connection object recycled
            return ids;
        }
    }// end of class
}// end of namespace
