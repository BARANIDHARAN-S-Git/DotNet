using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class Library_BLL
    {
        
            private int _Book_Id;

            public int Book_No
            {
                get { return _Book_Id; }
                set { _Book_Id = value; }
            }

            


            private string _Bname;

            public string Book_Name
            {

                get { return _Bname; }
                set
                {
                    if ((value.Length > 10) || (string.IsNullOrEmpty(value)))
                    {
                        throw new Exception("Book Name too long.. it shud not exceed 10 chars");
                    }
                    else
                    {
                        _Bname = value;
                    }

                }
            }

            private string _author;

            public string Author
            {
                //30
                get { return _author; }
                set { _author = value; }
            }


        private double _cost;
        public double Cost { get { return _cost; } set { _cost = value; } }

        private string _category;
        public string Category
        {
            get { return _category; } set { _category = value; }
        }

        private int _memberid;
        public int Memberid
        {
            get { return _memberid; } set { _memberid = value; }
        }
        private string _membername;
        public string Membername
        {
            get { return _membername; } set { _membername = value; }
        }

        private DateTime _accopendate;
        public DateTime Accounropendate
        {
            get
            {
                return _accopendate;
            }
            set
            {
                _accopendate = value;
            }
        }

        private int _maxbookallowed;
        public int MaximumBookAllowed
        {
            get
            {
                return _maxbookallowed;
            }
            set
            {
                _maxbookallowed = value;
            }
        }

        private double _penaltyamount;

        public double Penaltyamount
        {
            get
            {
                return _penaltyamount;
            }
            set
            {
                _penaltyamount = value;
            }
        }

        }
    
}
