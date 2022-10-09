using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<BookModel> booklist=new List<BookModel>();
            booklist.Add(new BookModel { Book_No=1,Book_Name="You can win",Authorname="John",price=120});
            booklist.Add(new BookModel { Book_No = 2, Book_Name = "power of positive thinking", Authorname = "Jack", price = 120 });
            ViewData["Mybooklist"]= booklist;
            return View();
        }
    }
}