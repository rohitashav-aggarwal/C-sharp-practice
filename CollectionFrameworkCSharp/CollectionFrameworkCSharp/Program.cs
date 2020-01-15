using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create  list and add some items in it/ Define some strings
            string[] players = {"Anthony", "Bob", "Elena", "Lucky", "Jarvis"};
            // specify initial capacity of the list to be 10
            List<string> strlist = new List<string>(10);
            // add items to the list using the existing array
            strlist.AddRange(players);
            // add individual items
            strlist.Add("Teena");
            strlist.Add("Amy");
            strlist.Add("Erin");
            // Examine the count and the capacity properties
            Console.WriteLine("Count and capacity: {0}, {1}", strlist.Count, strlist.Capacity);
            // access any item by its index
            Console.WriteLine("Item value: {0}", strlist[5]);
            //enumerate the items in the list using a foreach loop
            foreach (string s in players)
            {
                Console.WriteLine(s);
            }
            //Remove items form the list
            strlist.RemoveAt(2);
            strlist.Remove("Amy");
            // sort the list content
            strlist.Sort();
            foreach (string s in players)
            {
                Console.WriteLine(s);
            }

            // SEARCHING LIST CONTENT
            Console.WriteLine("SEARCHING LIST");
            // determines if a list contains a given item
            Console.WriteLine(strlist.Contains("Ron")); // should return false
            // The exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in a list
            bool found = strlist.Exists(x=> x.Length > 15); // lambda function
            // lambda function executed for each item in a list
            Console.WriteLine("Item Found: {0}", found);
            // use a find function to search through items
            string item = "";
            item = strlist.Find(c => c.StartsWith("A"));
            Console.WriteLine("Item: {0}",item);
            // Use findALL function to find multiple items
            List<string> itemList = strlist.FindAll(c => c.StartsWith("A"));
            foreach (string s in itemList)
            {
                Console.WriteLine(s);
            }
            // Use trueforall function to see if a given condition is true for all elements
            bool result = strlist.TrueForAll(c => c.Length < 10);
            Console.WriteLine("Result: {0}",result);

            // Don't let the console die
            Console.ReadKey();
        }
    }
}
