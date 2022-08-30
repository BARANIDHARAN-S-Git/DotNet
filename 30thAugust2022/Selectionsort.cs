using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30thAugust2022
{
    internal class Selectionsort
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the size of the array");
                int n=Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your entered input is : ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            

                SelectionSort(arr);
                Console.Read();

            }
            static void SelectionSort(int[] arr)
            {
                int MinIndex, i, j;
                int len = arr.Length - 1;
                for (i = 0; i < len; i++)
                {
                    MinIndex = i;
                    for (j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[MinIndex])
                        {
                            MinIndex = j;
                        }
                    }
                    if (MinIndex != i)
                    {
                        int temp = arr[MinIndex];
                        arr[MinIndex] = arr[i];
                        arr[i] = temp;
                    }
                }

                Console.WriteLine("------------Sorted-----------");
                for (int a = 0; a < arr.Length; a++)
                {
                    Console.WriteLine(arr[a]);
                }

            }
        
    }
}
