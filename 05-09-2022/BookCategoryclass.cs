using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class BookCategoryclass
    {

        public BookCategoryclass()
        {

        }
        public BookCategoryclass(int catid, int id, string catname, string description)
        {
           this.Catid = id;
            this.Catname = catname;
            this.Description = description;
            
           
        }

        private int _catid;
        public int Catid
        {
            get
            {
                return _catid;
            }
            set
            {
                _catid = value;
            }
        }
        private string _catname;
        public string Catname
        {
            get
            {
                return _catname;
            }
            set { _catname = value; }
        }

        private string _description;

        public string Description
        {
            get
            {
                return _description;
            }
            set {_description = value; }
        }
    }
}
