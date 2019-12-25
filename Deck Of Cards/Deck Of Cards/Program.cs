using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize array deck of 52 cards
            List<string> deck = new List<string>();

            // initialize suits
            string[] suits = { "Heart", "Spade", "Club", "Daimond" };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    // add the deck of cards inside the list deck
                    deck.Add((j + 1) + " " + suits[i] + "\n");
                }
            }
            // print the deck of cards
            deck.ForEach(Console.WriteLine);

            var birthday = new DateTime(1993, 08, 21);
            var difference = DateTime.Now - birthday;
            Console.WriteLine(difference.Days);
            Console.ReadKey();

        }

    }
    static class shuffleCards
    {
        private static Random gen = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = gen.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}

