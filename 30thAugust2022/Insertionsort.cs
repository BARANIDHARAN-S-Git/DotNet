using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30thAugust2022
{
    internal class Insertionsort
    {
        static void Insert(int[] arr)
        {

            int i, j, temp;
            int n = arr.Length;
            for (i = 0; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && temp <= arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }

        static void PrintSortedArray(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Enter the Element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your entered input is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Insert(arr);
            Console.WriteLine("-------------sorted-----------------");
            PrintSortedArray(arr);
            Console.Read();
        }
    }
}
