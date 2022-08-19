using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thday_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  n, sum = 0;
            Console.WriteLine("Enter the n");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i);
                    Console.WriteLine(" ");
                    sum += i;
                }
                
            }
            Console.WriteLine("the sum of n terms of odd natural number is"+" "+sum);
        }
    }
}
