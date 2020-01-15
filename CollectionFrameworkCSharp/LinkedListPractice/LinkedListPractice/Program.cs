using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList: items are accessed sequentially instead of using an index
            string[] songs = { "song1", "song2","song3", "song4","song4", "song6", "song7"};

            // create a linkedlist that holds strings
            LinkedList<string> mylist = new LinkedList<string>(songs);

            // items can be added to the front or the back of the list
            mylist.AddFirst("song0");
            mylist.AddLast("song8");

            // linkedlist can be interated
            foreach(string s in mylist)
            {
                Console.WriteLine(s);
            }

            // First and last properties return linkedlist nodes
            LinkedListNode<string> first = mylist.First;
            LinkedListNode<string> last = mylist.Last;
            Console.WriteLine(first.Value);
            Console.WriteLine(last.Value);

            // items can be added or removed relative to an existing item
            mylist.AddAfter(last, "song9");
            mylist.AddBefore(first, "song00");
            Console.WriteLine("**********************************");
            foreach (string s in mylist)
            {
                Console.WriteLine(s);
            }

            // search for items in the list with contains and find
            Console.WriteLine("**********************************");
            Console.WriteLine(mylist.Contains("song10"));
            Console.WriteLine(mylist.Find("song00").Value);
            // the list can then be travered with those properties
            Console.WriteLine(first.Next.Value);
            Console.WriteLine(last.Previous.Value);
            //
            Console.ReadKey();
        }
    }
}
