using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12thOctober2022.Models
{
    public class Book
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

        private int _Cost;
        public int Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
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