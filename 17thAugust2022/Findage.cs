using System;


namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime bday;
            int curryear;
            int birthyear;
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the bday");
            bday = Convert.ToDateTime(Console.ReadLine());
            birthyear = bday.Year;
            curryear = DateTime.Now.Year;
            int age = curryear - birthyear;
           
            Console.WriteLine("Hello" +" "+ name +" "+"your age is" +" "+ age);
            Console.ReadLine();

        }
    }
}
