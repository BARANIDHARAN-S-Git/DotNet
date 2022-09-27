using BusinessLogicLibrary;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("--------------------------------");
            Library_HL helper = new Library_HL();
            
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add New Book \n 2.Add Member \n3.Update Member\n 4. Exit ");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            Library_BLL Lib = new Library_BLL();
            switch (userchoice)
            {
                case 1:


                    Console.WriteLine("Enter the Book No");
                    Lib.Book_No=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Name");
                    Lib.Book_Name = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Author Name");
                    Lib.Author = Console.ReadLine();
                    Console.WriteLine("Enter the cost");
                    Lib.Cost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter category");
                    Lib.Category = Console.ReadLine();

                    bool queryStatus = helper.AddBook(Lib);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;

                    
                case 2:
                    Console.WriteLine("Enter the Member Id");
                    Lib.Memberid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Member Name");
                    Lib.Membername = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Account Open Date");
                    Lib.Accounropendate =Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter the Maximum Books Allowed");
                    Lib.MaximumBookAllowed = Convert.ToInt32(Console.ReadLine());
                        
                    Console.WriteLine("Enter Penalty Amount");
                    Lib.Penaltyamount =Convert.ToDouble(Console.ReadLine());

                    bool queryStatus1 = helper.Addmember(Lib);
                    if (queryStatus1)
                    {
                        Console.WriteLine("Member added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;

                case 3:

                    Console.WriteLine("Enter the Member Id");
                    Lib.Memberid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Member Name");
                    Lib.Membername = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Account Open Date");
                    Lib.Accounropendate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter the Maximum Books Allowed");
                    Lib.MaximumBookAllowed = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Penalty Amount");
                    Lib.Penaltyamount = Convert.ToDouble(Console.ReadLine());

                    bool queryStatus2 = helper.Updatemember(Lib);
                    if (queryStatus2)
                    {
                        Console.WriteLine("Member updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;


                
                    

                case 4:
                    Environment.Exit(1);
                    break;


            }

            Console.ReadLine();
        }

       
          
    }
}
