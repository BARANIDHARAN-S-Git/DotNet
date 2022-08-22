using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
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
                Console.WriteLine("Enter the arr{0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values stored in the array are : ");
            foreach (var array in arr)
            {

                Console.WriteLine(array + " ");

            }
            Array.Reverse(arr);

            Console.WriteLine("The values stored in the array in the reverse are:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
