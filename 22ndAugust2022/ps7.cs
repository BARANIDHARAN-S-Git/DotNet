using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Queue<int>numbers=new Queue<int>();
            Console.WriteLine("Enqueue");
            numbers.Enqueue(100);
            numbers.Enqueue(101);
            numbers.Enqueue(102);
            numbers.Enqueue(103);
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Dequeue");
            numbers.Dequeue();
            numbers.Dequeue();
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("peek");
            Console.WriteLine(numbers.Peek());
            Console.ReadLine();



        }
    }
}
