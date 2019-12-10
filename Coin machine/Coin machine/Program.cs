using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int two = 0;
            int loonies = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            //int pennies = 0;
            Console.WriteLine("Enter a number: ");
            double change = Convert.ToDouble(Console.ReadLine());
            double roundChange = Math.Round((Math.Round(change * 20, MidpointRounding.AwayFromZero) / 20), 5);
            change = roundChange;
            Console.WriteLine(roundChange);
            do
            {
                if (change >= 2)
                {
                    change = change - 2;
                    two++;
                }
                else if (change >= 1 && change <= 1.99)
                {
                    change = change - 1;
                    loonies++;
                }
                else if (change >= .25 && change <= .99)
                {
                    change = change - .25;
                    quarters++;
                }
                else if (change <= .24 && change >= .10)
                {
                    change = change - .10;
                    dimes++;
                }
                else if (change <= .09 && change >= .05)
                {
                    change = change - .05;
                    nickels++;
                }
                // If you want pennies, then uncomment the code and inside while change to 0
                /*else if (change <= .04 && change > 0)
                {
                    change = change - .01;
                    pennies++;
                }*/
            } while (change > 0.05);
            Console.WriteLine("Two: " + two);
            Console.WriteLine("loonies: " + loonies);
            Console.WriteLine("quarters: " + quarters);
            Console.WriteLine("dimes: " + dimes);
            Console.WriteLine("nickels: " + nickels);
            //Console.WriteLine("pennies: " + pennies);
            Console.ReadKey();
            
        }
    }
}
