using _7thOctober2022.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _7thOctober2022.DAL;
using _7thOctober2022.Models;
using System.Runtime.Remoting.Messaging;

namespace _7thOctober2022.Controllers
{
    public class HomeController : Controller
    {
        MemberDAL memberDAL = new MemberDAL();
        public ActionResult Index()
        {
            var memberlist = memberDAL.GetAllMembers();
            return View(memberlist);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MemberModel Mmember)
        {
            bool inserted = false;
            try
            {
                if (ModelState.IsValid)
                {
                    inserted = memberDAL.InsertMember(Mmember);
                    if (inserted)
                    {
                        TempData["SuccessMessage"] = "Member details Saved Successfully.....";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Unable to save the Member details....";
                    }

                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {

                TempData["ErrorMessage"] = "Unable to save the Member details....";

            }
            return View();

        }

        public ActionResult Edit(int id)
        {
            var Member = memberDAL.GetMembersById(id).FirstOrDefault();
           if (Member == null)
            {
                TempData["InfoMessage"] = "Mmeber Not Available with Id :" + id.ToString();
                return RedirectToAction("Index");
            }
            return View(Member);

        }
        [HttpPost,ActionName("Edit")]
        public ActionResult UpdateMember(MemberModel Member)
        {
           try
            { 
 
                if (ModelState.IsValid)
                {


                    bool updated = memberDAL.UpdateMember(Member);
                    if (updated)
                    {
                        TempData["SuccessMessage"] = "Member details Updated Successfully.....";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Unable to Update the Member details....";
                    }
                }

                return RedirectToAction("Index");
            }

            catch (Exception ex)
           {

                TempData["ErrorMessage"] = ex.Message;
                return View();
            }
           
        }


        public ActionResult Delete(int id)
         {
             try
             {
                 var member = memberDAL.GetMembersById(id).FirstOrDefault();
                 if(member==null)
                 {
                     TempData["InfoMessage"] = "Mmeber Not Available with Id :" + id.ToString();
                     return RedirectToAction("Index");

                 }
                 else
                 {
                     return View(member);
                 }
             }
             catch (Exception ex)
             {

                 TempData["ErrorMessage"] =ex.Message;
                 return View();
             }
         }
         [HttpPost,ActionName("Delete")]
         public ActionResult Deleteconfirmation(int id)
         {
           
            try
            {
                string result = memberDAL.deleteproduct(id);
                if(result.Contains("deleted"))
                {
                    TempData["SucessMessage"]=result;
                }
                else
                {
                    TempData["ErrorMessage"] = result;
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["ErrorMessade"]=ex.Message;
                return View();
            }

             
         }

        public ActionResult Details(int id)
        {
            try
            {
                var member = memberDAL.GetMembersById(id).FirstOrDefault();
                if(member==null)
                {
                    TempData["InfoMessage"] = "Mmeber Not Available with Id :" + id.ToString();
                    return RedirectToAction("Index");
                }
                return View(member) ;
            }
            catch(Exception ex)
            {
                TempData["ErrorMessade"] = ex.Message;
                return View();

            }
        }

       


    }
}