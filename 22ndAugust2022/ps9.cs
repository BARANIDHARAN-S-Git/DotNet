using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> floatnumbers=new List<float>() {1.3f,2.7f,4.5f,5.6f,7.8f};
            Console.WriteLine("Normal Order");
            foreach(var i in floatnumbers)
            {
                Console.WriteLine(i);
            }
            floatnumbers.Sort();
            Console.WriteLine("--------------");
            Console.WriteLine("Ascending Order");
            foreach (var i in floatnumbers)
            {
                Console.WriteLine(i);
            }
            floatnumbers.Reverse();
            Console.WriteLine("--------------");
            Console.WriteLine("Descending Order");
            foreach (var i in floatnumbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();


        }
    }
}
