using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ps7
    {
        static void Main(string[] args)
        {

            int firstnumber;
            int secondnumber;
            Console.WriteLine("Enter the firstnumber and secondnumber");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            secondnumber = Convert.ToInt32(Console.ReadLine());
            int output = 0;
            try
            {
                output = firstnumber / secondnumber;
                
            }
            catch (DivideByZeroException d)
            {
               Console.WriteLine("An exception ({0}) occurred.", d.GetType().Name);
                Console.WriteLine("Message:   {0}", d.Message);
                Console.WriteLine("Stack Trace:  {0}", d.StackTrace);
                Console.WriteLine("Division of {0} by zero.", firstnumber);
            }
            finally
            {
                Console.WriteLine("The output is : {0} ",output);
            }

        }
    }
}
