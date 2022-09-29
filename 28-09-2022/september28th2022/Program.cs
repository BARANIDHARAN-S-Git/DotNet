using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
using BusinessLogicLibrarydemo;

namespace september28th2022
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Menu ");
            Console.WriteLine("1)AddBooks \n2)Update Books \n3)Insert Member \n4)Update Member");

            int choice = Convert.ToInt32(Console.ReadLine());
            BookOperations b = new BookOperations();
            BookBAL bal = new BookBAL();
            MemberBAL bal1 = new MemberBAL();
            MemberOperations m=new MemberOperations();
            switch (choice)
            {



                case 1:
                    
                    Console.WriteLine("Add Books");
                    Console.WriteLine("enter BookNo");

                    bal.Book_No = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("entr BookName");
                    bal.Book_Name = Console.ReadLine();

                    Console.WriteLine("enter AuthorName");
                    bal.Author = Console.ReadLine();
                    Console.WriteLine("Enter the cost");
                    bal.cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the category");
                    bal.category = Console.ReadLine();

                    b.InsertBooks(bal);
                    Console.WriteLine("record Inserted successfully...");

                    break;

                    case 2:
                    Console.WriteLine("Update Books");
                    Console.WriteLine("enter bookno to update");
                    bal.Book_No = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("entr Bookname");
                    bal.Book_Name = Console.ReadLine();
                    Console.WriteLine("enter AuthorName");
                    bal.Author = Console.ReadLine();
                    Console.WriteLine("Enter the cost");
                    bal.cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the category");
                    bal.category = Console.ReadLine();
                    b.UpdateBooks(bal);
                    Console.WriteLine("Updated successfully....");


                    break;

                case 3:
                  
                    Console.WriteLine("Add Members");
                    Console.WriteLine("enter MemberId");

                    bal1.Memberid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("entr MemberName");
                    bal1.Membername = Console.ReadLine();

                    Console.WriteLine("enter Accountopendate");
                    bal1.AccountOpenDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter the MaxBooksAllowed");
                    bal1.MaximumBooksAllowed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Penalty Amount");
                    bal1.PenaltyAmount = Convert.ToInt32(Console.ReadLine());

                    m.InsertMembers(bal1);
                    Console.WriteLine("record Inserted successfully...");
                    break;
                case 4:
                    Console.WriteLine("Update Members");
                    Console.WriteLine("enter MemberNo to update");
                    bal1.Memberid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("entr Membername");
                    bal1.Membername = Console.ReadLine();

                    Console.WriteLine("enter Accountopendate");
                    bal1.AccountOpenDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter the MaxBooksAllowed");
                    bal1.MaximumBooksAllowed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Penalty Amount");
                    bal1.PenaltyAmount = Convert.ToInt32(Console.ReadLine());
                    m.UpdateMembers(bal1);
                    Console.WriteLine("Updated successfully....");
                    break;


            }

        }
    }
}
