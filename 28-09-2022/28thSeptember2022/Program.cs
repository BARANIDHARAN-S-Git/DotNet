using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrarydemo;

namespace _28thSeptember2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bookoperations b = new Bookoperations();
            MemberOperations m = new MemberOperations();
            List<BooksBAL> Books = b.GetBooks();
            List<MemberBAL> Members = m.GetMembers();

           Console.WriteLine("Menu ");
            Console.WriteLine("1)AddBooks \n2)Update Books \n3)Insert Member \n4)Update Member");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BooksBAL bal = new BooksBAL();
                    Console.WriteLine("Add Books");
                    Console.WriteLine("enter BookNo");

                    bal.book_no = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("entr BookName");
                    bal.bookname = Console.ReadLine();

                    Console.WriteLine("enter Author Name");
                    bal.author = Console.ReadLine();

                    b.InsertBooks(bal);
                    Console.WriteLine("record Inserted successfully...");
                    break;



                case 2:
                    BooksBAL bal1 = new BooksBAL();
                    Console.WriteLine("Update Books");
                    Console.WriteLine("enter bookno to update");
                    bal1.book_no = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("entr Bookname");
                    bal1.bookname = Console.ReadLine();
                    Console.WriteLine("enter AuthorName");
                    bal1.author = Console.ReadLine();
                    b.UpdateBooks(bal1);
                    Console.WriteLine("Updated successfully....");
                    break;


                   case 3:
                           MemberBAL bal2 = new MemberBAL();
                           Console.WriteLine("Add Members");
                           Console.WriteLine("enter MemberId");

                           bal2.Memberid = Convert.ToInt32(Console.ReadLine());
                           Console.WriteLine("entr MemberName");
                           bal2.Membername = Console.ReadLine();

                           Console.WriteLine("enter Accountopendate");
                           bal2.AccountOpenDate = Convert.ToDateTime(Console.ReadLine());
                           Console.WriteLine("Enter the MaxBooksAllowed");
                           bal2.MaximumBooksAllowed = Convert.ToInt32(Console.ReadLine());
                           Console.WriteLine("Enter the Penalty Amount");
                           bal2.PenaltyAmount = Convert.ToInt32(Console.ReadLine());

                           m.InsertMembers(bal2);
                           Console.WriteLine("record Inserted successfully...");
                    break;
                case 4:
                    MemberBAL bal3 = new MemberBAL();
                    Console.WriteLine("Update Members");
                    Console.WriteLine("enter MemberNo to update");
                    bal3.Memberid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("entr Membername");
                    bal3.Membername = Console.ReadLine();
                    
                    Console.WriteLine("enter Accountopendate");
                    bal3.AccountOpenDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter the MaxBooksAllowed");
                    bal3.MaximumBooksAllowed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Penalty Amount");
                    bal3.PenaltyAmount = Convert.ToInt32(Console.ReadLine());
                    m.UpdateMembers(bal3);
                    Console.WriteLine("Updated successfully....");
                    break;

                    break;



            }

        }
    }
}


