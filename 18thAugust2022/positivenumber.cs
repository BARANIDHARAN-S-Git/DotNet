using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstinteger, secondinteger;
            Console.WriteLine("Enter the first integer and second integer");
            firstinteger=Convert.ToInt32(Console.ReadLine());
            secondinteger=Convert.ToInt32(Console.ReadLine());
            if(firstinteger>0 & secondinteger > 0)
            {
                bool output = true;
                Console.WriteLine(output);
            }
            else
            {
                bool output = false;
                Console.WriteLine(output);
            }
        }
    }
}
