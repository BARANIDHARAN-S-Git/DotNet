using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace _6thSeptember2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            emp.work();
            Manager mngr=new Manager();
            mngr.work();
            Clerk clrk = new Clerk();
            clrk.work();
            Console.WriteLine("-----------------------------------------------------");
            
            
            Savings s=new Savings();
            s.printBalance();
            s.CalculateInterst();
           



            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" ");
            Current c=new Current();
            c.printBalance();
            c.CalculateInterst();



            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter the amount to withdraw from Savings");
            double withdrawfromsavings = Convert.ToDouble(Console.ReadLine());
            s.withdrawsavings(withdrawfromsavings);
            Console.WriteLine("Amount Withdrawn Successfully");
            s.printBalance();





            Console.WriteLine("-----------");

            Console.WriteLine("Enter the amount to deposit in the Savings");
            double depositintosavings = Convert.ToDouble(Console.ReadLine());
            s.Depositsavings(depositintosavings);
            Console.WriteLine("Amount Deposited Successfully");
            s.printBalance();
            s.duration();
            

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Enter the amount to withdraw from current");
            double withdrawcurrent=Convert.ToDouble(Console.ReadLine());
            c.withdrawcurrent(withdrawcurrent);
            Console.WriteLine("Amount Withdrawn Successfully");
            c.printBalance();
            
           
            
            
            Console.WriteLine("-----------");
            
            Console.WriteLine("Enter the amount to deposit in the current");
            double depositcurrrent = Convert.ToDouble(Console.ReadLine());
            c.Depositcurrrent(depositcurrrent);
            Console.WriteLine("Amount Deposited Successfully");
            c.printBalance();
            c.duration();
            


            Console.ReadLine();
        }
    }
}
