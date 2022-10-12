using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedBLL
{
    public class Book_BAL
    {
       
        private int _Book_No;
        public int Book_No
        {
            get { return _Book_No; }
            set { _Book_No = value; }
        }

        private string _Book_Name;
        public string Book_Name
        {
            get { return _Book_Name; }
            set { _Book_Name = value; }
        }

        private string _Author;
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

      
        private string _Category;

        public string Category
        {
            get
            {
                return _Category;
            }
            set
            {
                _Category = value;
            }
        }


    }
}