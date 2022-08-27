using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _26thAugust2022
{
    internal class ps4
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("Hi,I am Barani");
            mylist.AddLast("Thank you");
            mylist.AddAfter(mylist.First, "Welcome all");
            mylist.AddBefore(mylist.Last, "Hope you  all are fine");
            mylist.AddAfter(mylist.First.Next, "Hello everyone");
            mylist.AddBefore(mylist.Last.Previous, "It's nice to meet you all");
            LinkedListNode<string> node = mylist.Find("Welcome all");
            node.Value = "Welcome to one and all present here";
                
           

            foreach (string s in mylist)
            {
                Console.WriteLine(s);
            }

        }
    }
}
