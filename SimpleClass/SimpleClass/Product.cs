using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Product
    {
        // private data
        private string name;
        private decimal price;
        private int qty;

        // public properties
        public string Name
        {
            get { return name;}
            set
            {
                name = value; // use the value provided when property is used
            }
        }
        public decimal Price
        {
            get{ return price; }
            set
            {
                // if provided value is negative, make it zero
                price = (value < 0) ? -value : value;
            }
        }
        public int Qty
        {
            get { return qty; }
            set
            {
                // if provided value is negative, make it zero
                qty = (value < 0) ? -value : value;
            }
        }


        // constructors
        // if you do not provide a constructor, compiler supplies default 
        //  constructor (no parameters)
        public Product() { } // default constructor
        public Product(string n, decimal p, int q) // constructor with params
        {
            Name = n;
            Price = p;
            Qty = q;    
        }

        // public operations

        public override string ToString()
        {
            return name + ": " + price.ToString("c") + ", " + qty.ToString();
        }

    }
}
