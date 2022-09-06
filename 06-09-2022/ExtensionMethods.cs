using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public static  class ExtensionMethods
    {


        public static void withdrawsavings(this Savings s, double withdraw)
        {
            if (withdraw < s.Amount)
            {
                s.Amount = s.Amount - withdraw;
                Savings.previouswithdraw = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Sorry Not able to withdraw wheter you have entered amount more than the balance amount .");
            }

           


        }
        public static void Depositsavings(this Savings s, double deposit)
        {

            s.Amount = s.Amount + deposit;
            Savings.previousdeposit = DateTime.Now;




        }


        public static void withdrawcurrent(this Current c,double withdraw)
        {

            
            if (withdraw < c.Amount)
            {
                c.Amount = c.Amount - withdraw;
                Current.previouswithdraw = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Sorry Not able to withdraw wheter you have entered amount more than the balance amount .");
            }


        }
        public static void Depositcurrrent(this Current c,double deposit)
        {
            
            c.Amount = c.Amount+deposit;
            Current.previousdeposit= DateTime.Now;
            


        }

    }
}
