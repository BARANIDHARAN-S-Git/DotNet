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
        public void InsertMembers(MemberBAL bal2)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            Member m1 = new Member();
            m1.Member_Id = bal2.Memberid;
            m1.Member_Name = bal2.Membername;
            m1.Acc_Open_Date = bal2.AccountOpenDate;
            m1.Max_Books_Allowd = bal2.MaximumBooksAllowed;
            m1.Penalty_Amount = bal2.PenaltyAmount;
            context.Members.Add(m1);
            context.SaveChanges();

        }


        public void UpdateMembers(MemberBAL bal)
        {
            LibrarySystemEntities context = new LibrarySystemEntities();
            List<Member> Members = context.Members.ToList();
            Member obj = Members.Find(mem => mem.Member_Id == bal.Memberid);
            obj.Member_Name = bal.Membername;
            obj.Acc_Open_Date = bal.AccountOpenDate;
            obj.Max_Books_Allowd = bal.MaximumBooksAllowed;
            obj.Penalty_Amount= bal.PenaltyAmount;
            context.SaveChanges();

        }


      


    }
}