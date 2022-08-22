using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable A = new Hashtable();
            Console.WriteLine("Add");
            A.Add(1, "First");
            A.Add(2, "Second");
            A.Add(3, "Third");
            A.Add(4, "Fourth");
            IDictionaryEnumerator dictionaryEnumerator = A.GetEnumerator();
            foreach(DictionaryEntry item in A)
            {
                Console.WriteLine(item.Key +" : "+item.Value);
            }
            Console.WriteLine("Remove");
            A.Remove(1);
            foreach (DictionaryEntry item in A)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }


            Console.ReadLine();
        }
    }
}
