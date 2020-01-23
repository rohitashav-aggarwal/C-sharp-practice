/*
 * @Author: Rohitashav Aggarwal
 * @Date: 22 January 2020
 * @Purpose: Retrieve/Update orders for a particular OrderID and display statistics
 * @Class: CPRG-200 lab 4 - OOSD Program - SAIT
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RohitashavAggarwal_CPRG200_Lab4
{
    // connection string to connect with northswind database.
    public static class NorthwindCon
    {
        public static SqlConnection GetConnection()
        {
            string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connection);
        }
    }
}
