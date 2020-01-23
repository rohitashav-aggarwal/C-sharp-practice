using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(writeY);
            t.Start(); // begin the thread
            t.Join(); // wait for t thread to finish before running the for loop

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void writeY()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("Y");
            }
        }
    }
}
