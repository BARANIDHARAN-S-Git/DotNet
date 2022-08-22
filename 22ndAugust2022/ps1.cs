using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the arr{0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The elements in the array are:");
            foreach (var array in arr)
            {

                Console.Write(array + " ");
            }
            Console.ReadLine();
        }
    }
}
