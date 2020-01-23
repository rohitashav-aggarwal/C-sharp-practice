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
    public static class OrderDetailsDB
    {
        public static List<OrderDetails> GetOrderDetails(int OrderId)
        {
            List<OrderDetails> datadetail = new List<OrderDetails>(); // list to store orders table data
            using (SqlConnection connection = NorthwindCon.GetConnection())
            {
                // query to extract columns from orders table
                string query1 = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                               "FROM [Order Details] " +
                               "WHERE OrderID = @OrderID";
                using (SqlCommand cmd1 = new SqlCommand(query1, connection))
                {
                    cmd1.Parameters.AddWithValue("@OrderID", OrderId);
                    connection.Open();
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        while(reader.Read()) // while loop to read all the rows associated with one order id
                        {
                            OrderDetails orderdata = new OrderDetails();
                            
                            orderdata.OrderID = Convert.ToInt32(reader["OrderID"]);
                            orderdata.ProductID = Convert.ToInt32(reader["ProductID"]);
                            orderdata.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                            orderdata.Quantity = Convert.ToInt16(reader["Quantity"]);
                            orderdata.Discount = Convert.ToDouble(reader["Discount"]);
                            datadetail.Add(orderdata);
                            
                        }
                    }
                }
            }
            return datadetail; // returning the list with all the data
        }
    }// end class
}// end namespace
