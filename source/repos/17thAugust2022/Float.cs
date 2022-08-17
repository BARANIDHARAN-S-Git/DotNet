using System;


namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radius;
            Console.WriteLine("Enter the radius");
            radius=Convert.ToSingle(Console.ReadLine());
            double area = 3.14 * radius * radius;
            Console.WriteLine("The area is" + " "+area);
        }
    }
}
