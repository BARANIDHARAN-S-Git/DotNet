using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList first = new ArrayList(5);
            Console.WriteLine("Addd");
            first.Add(1);
            first.Add("second");
            first.Add(3);
            first.Add("fourth");
            first.Add(5);
            Console.WriteLine(first[0]);
            Console.WriteLine(first[1]);
            Console.WriteLine(first[2]);
            Console.WriteLine(first[3]);
            Console.WriteLine(first[4]);
            Console.WriteLine("----------------");
            Console.WriteLine("Remove");
            first.Remove(first[0]);
            Console.WriteLine(first[0]);
            Console.WriteLine(first[1]);
            Console.WriteLine(first[2]);
            Console.WriteLine(first[3]);
            Console.WriteLine("----------------");
            Console.WriteLine("count");
            Console.WriteLine(first.Count);


            Console.ReadLine();


        }
    }
}
