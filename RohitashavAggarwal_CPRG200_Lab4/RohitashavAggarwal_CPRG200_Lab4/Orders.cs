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

namespace RohitashavAggarwal_CPRG200_Lab4
{
    // declaring orders table variables and adding get set
    public class Orders
    {
        // default constructor
        public Orders() { }

        public int OrderId { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
