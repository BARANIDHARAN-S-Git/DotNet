using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
using DataAccessLibrary;

namespace HelperLibrary
{
    public class Library_HL
    {
        
        Library_DAL dal = null;
        public Library_HL()
        {
            dal = new Library_DAL();
        }


        public bool AddBook(Library_BLL Library)
        {
            return dal.InserBook(Library);

        }

        public bool Addmember(Library_BLL Library)
        {
            return dal.InsertMember(Library);

        }

        public bool Updatemember(Library_BLL Library)
        {
            return dal.Updatememberdetails(Library);
        }

       













    }
}

