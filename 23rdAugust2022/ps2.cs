using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ps2
    {
        static void Main(string[] args)
        {
            ps2 a=new ps2();
            Console.WriteLine("The sum of a and b is : "+a.add());
        }

        public int add()
        {
            int a,b;
            Console.WriteLine("Enter a and b");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            return sum;


        }
    }
}
