using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disconnected_DAL;
using DisconnectedBLL;
namespace HelperLibrary
{
    public class BookHelper
    {
        BookDAL dal = null;
        public BookHelper()
        {
            dal = new BookDAL();
        }


        public int RowCountBook()
        {
            return dal.RowCountBook();

        }
        public bool AddNewBook(Book_BAL Book)
        {
            return dal.InsertBook(Book);
        }
        public Book_BAL LocateBook(int Book_No)
        {
            return dal.FindBook(Book_No);
        }

        public List<Book_BAL> BookList()
        {
            return dal.ShowAllBooks();
        }

        public bool RemoveBookData(int Book_No)
        {
            return dal.DeleteBook(Book_No);
        }



        public bool EditBookData(int Book_No, Book_BAL Book)
        {
            return dal.UpdateBook(Book_No, Book);
        }




    }
}