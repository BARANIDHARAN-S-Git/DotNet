using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{

    public class BankDomain
    {

        public class Borrower
        {
            [Key]
            [Required]
            public int borrowerid { get; set; }

            [MaxLength(30, ErrorMessage = "Not allowed above 20 chars")]
            [MinLength(3, ErrorMessage = "Not allowed below 2 chars")]
            public string borr_name { get; set; }

            public string City { get; set; }

            public string state { get; set; }

            public string country { get; set; }

            public string street { get; set; }

            public string companyname { get; set; }

            public string jobname { get; set; }

        }

        public class Loan
        {
            [Key]
            public int LoanID { get; set; }

            public string LoanType { get; set; }

            [Range(10000, 200000, ErrorMessage = "not in range")]
            public int Amount { get; set; }

            public string duration { get; set; }

            public string RateOfInterest { get; set; }

        }



        public class MyContext : DbContext
        {
            public MyContext() : base("MyContext")
            {

                Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
            }

            public virtual DbSet<Borrower> BorrowerTable { get; set; }
            public virtual DbSet<Loan> LoanTable { get; set; }

        }

    }
  

}