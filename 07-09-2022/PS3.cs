using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void addsubmultiply(int a,int b);
    
    public class PS3
    {
        public void sum(int a,int b)
        {
            Console.WriteLine("The sum of two numbers {0} and {1} is : {2}", a, b, (a + b));
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("The subtract of two numbers {0} and {1} is : {2}", a, b, (a - b));
        }

        public void multiply(int a, int b)
        {
            Console.WriteLine("The multiply of two numbers {0} and {1} is : {2}", a, b, (a*b));
        }

    }
}
