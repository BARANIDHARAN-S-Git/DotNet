using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class IssueController : Controller
    {
        // GET: Issue
        public ActionResult Index()
        {
            List<IssueModel> IssueList = new List<IssueModel>();
            IssueList.Add(new IssueModel { Lib_Issue_Id = 1, Book_No = 1, Member_Id = 23 });
            IssueList.Add(new IssueModel { Lib_Issue_Id = 2, Book_No = 34, Member_Id = 25 });


            TempData["myIssuedata"] = IssueList;
            return RedirectToAction("GetList");
            
        }
        public ActionResult GetList()
        {
            
            TempData["mybag"] = TempData["myIssuedata"];

            return View();
        }
    }
}
