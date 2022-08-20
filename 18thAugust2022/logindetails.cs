using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname;
            Console.WriteLine("Enter the Firstname");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter the Lastname");
            lastname = Console.ReadLine();
            if( !string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(lastname) || firstname=="Barani" && lastname == "Dharan")
            {
                Console.WriteLine("TH userId is{0} and password is {1}",firstname,lastname); ;
                Console.WriteLine("Thank you,User is successfully logged in");
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to my app");
            }
            else
            {
                Console.WriteLine("Sorry user is not successfully logged in");
            }
            Console.ReadLine();
                
         }
    }
}
