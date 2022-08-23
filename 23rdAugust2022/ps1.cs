using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program c=new Program();
            c.sum();

        }
        public void sum()
        {
            int a, b;
            Console.WriteLine("Enter a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            Console.WriteLine("The sum of {0} and {1} is : {2}", a, b, sum);
        }
        
    }
}
