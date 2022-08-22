using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class ps11
    {
        static void Main(string[] args)
        {

            SortedList<int,string> names=new SortedList<int,string>();
            names.Add(2, "Thiru");
            names.Add(6, "Prakash");
            names.Add(1, "Vel");
            names.Add(3, "chiranjeevi");
            names.Add(5, "Dinesh");
            names.Add(4, "Priyadharshan");
            Console.WriteLine("Sorted List");
            Console.WriteLine(" ");

            foreach(var i in names)
            {
                Console.WriteLine("key:{0}  value:{1}",i.Key,i.Value);
            }
            Console.ReadLine();
        }
    }
}
