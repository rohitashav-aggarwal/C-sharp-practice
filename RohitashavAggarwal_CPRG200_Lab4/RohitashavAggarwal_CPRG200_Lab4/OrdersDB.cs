/*
 * @Author: Rohitashav Aggarwal
 * @Date: 22 January 2020
 * @Purpose: Retrieve/Update orders for a particular OrderID and display statistics
 * @Class: CPRG-200 lab 4 - OOSD Program - SAIT
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohitashavAggarwal_CPRG200_Lab4
{
    // Retreives one order from the database
    public static class OrdersDB
    {
        public static Orders GetOrders(int OrderId)
        {
            Orders order = null;
            using (SqlConnection connection = NorthwindCon.GetConnection()) 
            {
                // query with parameter selection to extract one order data
                string query = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, Shippeddate " +
                               "FROM Orders " +
                               "WHERE OrderID = @OrderID";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", OrderId);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // reading one row from the database based on given order id
                        {
                            order = new Orders();
                            order.OrderId = (int)reader["OrderID"];
                            order.CustomerID = reader["CustomerID"].ToString();
                            order.OrderDate = (reader["orderdate"] == DBNull.Value) ? null : (DateTime?)reader["orderdate"];
                            order.RequiredDate = (reader["RequiredDate"] == DBNull.Value) ? null : (DateTime?)reader["RequiredDate"];
                            order.ShippedDate = (reader["Shippeddate"] == DBNull.Value)? null : (DateTime?)reader["Shippeddate"];
                        }
                    }
                }
            }
            return order;
        }

        // update method to accept new shipping date except null values
        public static void UpdateShippingDate(DateTime? newDate, int id)
        {
            
            using (SqlConnection connection = NorthwindCon.GetConnection())
            {
                string updatedate = "update orders set shippeddate = @newShippedDate Where OrderID = @OrderID"; // to identify record
                using (SqlCommand cmd = new SqlCommand(updatedate, connection))
                {
                    cmd.Parameters.AddWithValue("@newShippedDate", newDate);
                    cmd.Parameters.AddWithValue("@OrderID", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Update method using same name but different signatures to accept null values
        public static void UpdateShippingDate(int id)
        {
            using (SqlConnection connection = NorthwindCon.GetConnection())
            {
                string updatedate = "update orders set shippeddate = @newShippedDate Where OrderID = @OrderID"; // to identify record
                using (SqlCommand cmd = new SqlCommand(updatedate, connection))
                {
                    cmd.Parameters.AddWithValue("@newShippedDate", DBNull.Value);
                    cmd.Parameters.AddWithValue("@OrderID", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }// end class
}// end namespace
