using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableCodelibraray;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string first, second;
            Console.WriteLine("ps1--------------");
            Console.WriteLine("Enter the first string");
            first = Console.ReadLine();
            Console.WriteLine("Enter the second string");
           
            second= Console.ReadLine();
            Comparetwwostring.twostring(first, second);
            Console.WriteLine("-------------------");
            Console.WriteLine("ps2---Copy Method");
            Console.WriteLine(" ");
            copymethod.Cm(first);
           
            Console.WriteLine("[-------------------");
            Console.WriteLine("ps3--Indexof  Method");
            Console.WriteLine(" ");
            indexofmethod.iom("Barani");

            Console.WriteLine("-------------------");
            Console.WriteLine("ps4--Split Method");
            Console.WriteLine(" ");
            splitmethod.Split();


            Console.WriteLine("-------------------");
            Console.WriteLine("ps5--String into uppercase");
            Console.WriteLine(" ");
            uppercase.uc(first);

            Console.WriteLine("-------------------");
            Console.WriteLine("ps6--creat a file ");
            Console.WriteLine(" ");
            file.fl();
            Console.WriteLine("File is successfully created at the path");

            Console.WriteLine("-------------------");
            Console.WriteLine("ps7--Day properties");
             Dayproperties.dp();




        }
    }
}
