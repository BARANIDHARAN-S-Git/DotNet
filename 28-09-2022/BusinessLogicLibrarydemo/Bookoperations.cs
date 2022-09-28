using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrarydemo
{
    public class Bookoperations
    {
        public void InsertBooks(BooksBAL bal)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            Book b1 = new Book();
            b1.Book_No = bal.book_no;
            b1.Book_Name = bal.bookname;
            b1.Author = bal.author;
            b1.cost = bal.cost;
            b1.category=bal.category;
            context.Books.Add(b1);
            //context.SaveChanges();

        }

     
        public void UpdateBooks(BooksBAL bal)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            List<Book> customers = context.Books.ToList();
            Book obj = customers.Find(cust => cust.Book_No == bal.book_no);
            obj.Book_Name = bal.bookname;
            obj.Author = bal.author;
            context.SaveChanges();

        }


        public List<BooksBAL> GetBooks()
        {
            LibrarySystemEntities context = new LibrarySystemEntities();

            List<Book> clist = context.Books.ToList();
            List<BooksBAL> cblist = new List<BooksBAL>();
            foreach (var item in clist)
            {
                cblist.Add(new BooksBAL { book_no = item.Book_No, bookname = item.Book_Name, author = item.Author });



            }
            return cblist;

        }

      

    }
}
