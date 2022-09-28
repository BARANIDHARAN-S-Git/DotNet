using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrarydemo
{
    public class MemberOperations
    {
        public void InsertMembers(MemberBAL bal)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            Member m = new Member();
            m.Member_Id = bal.Memberid;
            m.Member_Name = bal.Membername;
            m.Acc_Open_Date = bal.AccountOpenDate;
            m.Max_Books_Allowd = bal.MaximumBooksAllowed;
            m.Penalty_Amount = bal.PenaltyAmount;
            context.Members.Add(m);
            context.SaveChanges();

        }


        public void UpdateMembers(MemberBAL bal)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            List<Member> Members = context.Members.ToList();
            Member obj = Members.Find(mem => mem.Member_Id == bal.Memberid);
            obj.Member_Name = bal.Membername;
            obj.Max_Books_Allowd = bal.MaximumBooksAllowed;
            context.SaveChanges();

        }


        public List<MemberBAL> GetMembers()
        {
            LibrarySystemEntities context = new LibrarySystemEntities();

            List<Member> clist = context.Members.ToList();
            List<MemberBAL> memlist = new List<MemberBAL>();
            foreach (var item in memlist)
            {
                memlist.Add(new MemberBAL { Memberid = item.Memberid, Membername = item.Membername, MaximumBooksAllowed = item.MaximumBooksAllowed });



            }
            return memlist;

        }


    }
}