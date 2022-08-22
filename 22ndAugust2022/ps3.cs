using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the n");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the arr- {0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            
            int sum = 0;
            Console.WriteLine("The sum of all elements stored in the array is :");
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            

          

            Console.ReadLine();
        }
    }
}
