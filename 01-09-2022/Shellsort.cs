using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stSeptember2022
{
    internal class Shellsort
    {
        static void Main(string[] args)
        {
            ShellSort();
            Console.Read();
        }
        static void printAll(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        static void ShellSort()
        {

            Console.Write("Enter the number of elements in the array : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your entered input are : ");
           
               
                printAll(arr);
            

            
           

            for(int gap = n / 2; gap >= 1; gap = gap / 2)
            {
                for(int j = gap; j < n; j++)
                {
                    for(int i = j - gap; i >= 0; i-= gap)
                    {
                        if (arr[i + gap] > arr[i])
                        {
                            break;
                        }

                        else
                        {
                            int temp = arr[i + gap];
                            arr[i+gap]=arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("----------sorted------------");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
