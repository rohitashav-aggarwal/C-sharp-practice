using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1; // defines reference variable
            p1 = new Product(); // create an object - 
                                //implicit call to default constructor
            p1.Name = "gadget";
            p1.Price = 9.99m;// use set part of property Price
            //Console.WriteLine("The price is " + p1.Price.ToString("c")); // uses get part of property Price
            p1.Qty = 15;
            
            Console.WriteLine(p1);// implicit call to ToString() method

            Product p2 = new Product("widget", -7.99m, -25); // implicit call to
                                                            // constructor with params
            Console.WriteLine(p2);


            Console.WriteLine("\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
