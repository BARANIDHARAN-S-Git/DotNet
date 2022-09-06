using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Savings:IBank
    {

        public static DateTime previousdeposit = new DateTime();
        public static DateTime previouswithdraw = new DateTime();

        public static double amount = 40000;

       

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public void printBalance()
        {
            
            Console.WriteLine("Balance : "+amount);
        }

        public void CalculateInterst()
        {
            
            
            double interest;
            interest = (amount*0.04f*30)/365;
            Console.WriteLine("The interst from savings : " + interest);

        }
        public void duration()
        {
            Console.WriteLine("The numbers of days deposit amount kept in the bank"+previousdeposit.Subtract(previouswithdraw));
        }





    }
   
}
