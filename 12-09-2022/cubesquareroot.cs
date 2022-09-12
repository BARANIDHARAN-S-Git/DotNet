using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculator
{
    public class cubesquareroot
    {
        public double number { get; set; }
        
        public void read(double Number)
        {
           number=Number;

        }
        public void  cube()
        {
            Console.WriteLine("Cube of number : {0} is : {1}",number,number*number*number);
            

        }

       public void squareroot()
        {
            Console.WriteLine("Square root of the number : {0} is : {1}",number,Math.Sqrt(number));
        }
    
    }
}
