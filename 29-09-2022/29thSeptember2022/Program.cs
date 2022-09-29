using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLibrary.BankDomain;

namespace _29thSeptember2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.BorrowerTable.Add(new Borrower { borrowerid = 1, borr_name = "Buttler", City = "Chennai", state = "Tamilnadu", country = "India", street = "19,AJF Garden", companyname = "Mphasis", jobname = "Software Engineer" });
            context.LoanTable.Add(new Loan { LoanID = 1, LoanType = "EducationLoan", Amount = 100000, duration = "2years", RateOfInterest =" 2.7 % p.a" });
            context.SaveChanges();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
