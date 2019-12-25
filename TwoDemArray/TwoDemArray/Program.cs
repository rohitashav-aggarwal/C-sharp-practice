using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDemArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] shirts = { {345, 564, 1245, 1690}, {1232, 1534, 795, 238}, {1189, 1387, 987, 546} };
            Console.WriteLine("Black color shirts total: " + (shirts[0,0] + shirts[0, 1] + shirts[0, 2] + shirts[0, 3]));
            //Console.WriteLine(shirts);
            int blackShirts = 0;
           
            
            for(int i = 0; i<4; i++)
            {
                blackShirts += shirts[0, i];
            }
            Console.WriteLine(blackShirts);
            
            

            List<Human> humans = new List<Human>();
            Human parneet = new Human();
            parneet.setName("Parneet");
            parneet.setAge(25);

            Human rohit = new Human();
            rohit.setName("Rohit");
            rohit.setAge(23);

            humans.Add(parneet);
            humans.Add(rohit);
            //humans.ForEach(Console.WriteLine);
            Human human = humans.ElementAt(0);
            human.setAge(35);
            Console.WriteLine(humans.ElementAt(0).getName().ToString());
            Console.WriteLine(humans.ElementAt(0).getAge().ToString());

            Console.WriteLine("Element at 1: "+ humans.ElementAt(1).getName().ToString());
            Console.WriteLine("Element at 1: " + humans.ElementAt(0).getAge().ToString());
            Console.ReadKey();
        }
    }
}
