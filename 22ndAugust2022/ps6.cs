using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Stack<int> a = new Stack<int>();
            Console.WriteLine("Stack -push");
            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);
            

            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Before pop");
            foreach(var  i in a)
            {
                Console.WriteLine(i);
            }
            a.Pop();
            a.Pop();
            Console.WriteLine("-------------");
            Console.WriteLine("After pop");
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("peek");
            Console.WriteLine("The topmost element in the stack is: ");
            Console.WriteLine(a.Peek());
            Console.WriteLine("-------------");
            Console.WriteLine("count");
            Console.WriteLine(a.Count);
            Console.ReadLine();

        }
    }
}
