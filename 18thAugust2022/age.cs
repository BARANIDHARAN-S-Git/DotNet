using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you look older than"+" "+age);
        }
    }
}
