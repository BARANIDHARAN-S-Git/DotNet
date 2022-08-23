using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ps6
    {
        enum deptnames
        {
            Purchase = 1,
            Sales = 2,
            Training = 3,
            Accounts = 4
        };
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the input");
            input = Console.ReadLine();
            int output=(int)Enum.Parse(typeof(deptnames), input);
            Console.WriteLine(output);
           
            
        }
        
     
        
    }
}