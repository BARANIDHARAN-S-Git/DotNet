using Library.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        static List<Member>Memberlist=new List<Member>();
        static MemberController()
        {
            //Memberlist.Add(new MemberModel { Memberid = 1, Membername = "Buttler", AccountOpenDate = new DateTime(2022, 04, 06), MaximumBooksAllowed = 4, penaltyamount = 250 });
            //Memberlist.Add(new MemberModel { Memberid = 2, Membername = "Axar", AccountOpenDate = new DateTime(2022, 03, 08), MaximumBooksAllowed = 5, penaltyamount = 350 });
            


        }
        public ActionResult Index()
        {
          /* List<MemberModel> Memberlist = new List<MemberModel>();
            Memberlist.Add(new MemberModel { Memberid = 1, Membername = "Buttler", AccountOpenDate = new DateTime(2022, 04, 06), MaximumBooksAllowed = 4, penaltyamount = 250 });
            Memberlist.Add(new MemberModel { Memberid = 2, Membername = "Axar", AccountOpenDate = new DateTime(2022, 03, 08), MaximumBooksAllowed = 5, penaltyamount = 350 });
            ViewBag.members = Memberlist;*/
            return View(Memberlist);
        }

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Member model)
        {
            Memberlist.Add(model);
            return RedirectToAction("Index");
        }
    }
}