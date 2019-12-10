using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            int x = 5;
            int y;
            // Operator after the variable - operation takes place "after"
            // Operator before the variable - operation takes place "before"
            y = x++;
            Console.WriteLine("x: " + x + " and y: " + y);
            y = --x;
            Console.WriteLine("x: " + x + " and y: " + y);
            Console.WriteLine("\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
