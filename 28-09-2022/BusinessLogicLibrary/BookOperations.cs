using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;
using System.Data.Entity;


namespace BusinessLogicLibrary
{
    public class BookOperations
    {
        public void InsertBooks(BookBAL bal)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            Book book = new Book();
            book.Book_No = bal.Book_No;
            book.Book_Name = bal.Book_Name;
            book.Author = bal.Author;
            book.cost = bal.cost;
            book.category = bal.category;
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void UpdateBooks(BookBAL bal)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            List<Book> customers = context.Books.ToList();
            Book obj = customers.Find(cust => cust.Book_No == bal.Book_No);
            obj.Book_Name = bal.Book_Name;
            obj.Author = bal.Author;
            obj.cost = bal.cost;
            obj.category = bal.category;
            context.SaveChanges();

        }



    }
}
