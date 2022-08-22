using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class ps10cs
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> d=new Dictionary<int,string>();
            d.Add(2, "Thiru");
            d.Add(6, "Prakash");
            d.Add(1, "Vel");
            d.Add(3, "chiranjeevi");
            d.Add(5, "Dinesh");
            d.Add(4, "Priyadharshan");
            Console.WriteLine("Dictionary");
            Console.WriteLine(" ");
            foreach(KeyValuePair<int,string> item  in d)
            {
                Console.WriteLine("key :"+item.Key +" "+"value : " + item.Value);
            }






            Console.ReadLine();
        }
    }
}
