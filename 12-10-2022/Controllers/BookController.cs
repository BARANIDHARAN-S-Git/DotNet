using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _12thOctober2022.Models;
using DisconnectedBLL;

namespace _12thOctober2022.Controllers
{
   // [RoutePrefix("MEmp")]
    public class BookController : ApiController
    {
        
       
            // GET api/<controller>
            BookHelper obj = null;
            public BookController()
            {
                obj = new BookHelper();
            }

          // [Route("GetAllEmps")]
            public List<Book> GetEmpList()
            {
              
                List<Book_BAL> Bookbal = new List<Book_BAL>(); Bookbal = obj.BookList();
                List<Book> Book = new List<Book>();
                foreach (var item in Bookbal)
                {
                    //Employees emp = new Employees();
                    Book.Add(new Book { Book_No = item.Book_No, Book_Name = item.Book_Name, Author = item.Author, Category = item.Category });
                }
                return Book;

            }

           //// [Route("~/FindEmp")]
           //public Book GetBookDetails()
           // {
           // return new Book
           // {


           //     Book_No = 1,
           //     Book_Name = "You can win",
           //     Author = "John",
           //     //Cost = 120,
           //     Category = "Novel"
           //     };
           // }
            // GET api/<controller>/5
           // [Route("~/FindEmp/{id}")]
            //  [Route("FindEmp/{id:int:min(1)}")]
            //[Route("FindEmp/{id:int?}")]
           /* public  Book GetBooksByID(int id = 1)
            {
                Book_BAL Bookbal = new Book_BAL();
                Bookbal = obj.LocateBook(id);
                Book b = new Book();
                b.Book_No = Bookbal.Book_No;
                b.Book_Name = Bookbal.Book_Name;
                b.Author = Bookbal.Author;
                //b.Cost = Bookbal.Cost;
                b.Category = Bookbal.Category;
                return b;
                //return "value";
            }
           */
        // POST api/<controller>
        public HttpResponseMessage PostProduct([FromBody] Book Bookdata)
            {
                Book_BAL bookbal = new Book_BAL();
            bookbal.Book_No = Bookdata.Book_No;
            bookbal.Book_Name = Bookdata.Book_Name;
            bookbal.Author = Bookdata.Author;
            //bookbal.Cost = Bookdata.Cost;
            bookbal.Category = Bookdata.Category;


                bool ans = obj.AddNewBook(bookbal);
                if (ans)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable);
                }

            }

            // PUT api/<controller>/5
            public HttpResponseMessage PutProduct(int id, [FromBody] Book Bookdata)
            {

                Book_BAL bookbal = new Book_BAL();
            bookbal.Book_No = Bookdata.Book_No;
            bookbal.Book_Name = Bookdata.Book_Name;
            bookbal.Author = Bookdata.Author;
           // bookbal.Cost = Bookdata.Cost;
            bookbal.Category = Bookdata.Category;

            bool ans = obj.EditBookData(id, bookbal);
                if (ans)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable);
                }
            }

            // DELETE api/<controller>/5
            public HttpResponseMessage DeleteProduct(int id)
            {
                bool ans = obj.RemoveBookData(id);
                if (ans)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable);
                }

            
        }
    }
}