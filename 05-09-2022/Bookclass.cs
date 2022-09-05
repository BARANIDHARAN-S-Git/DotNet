using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace Book
{
    public class Bookclass


    {

        
        public Bookclass()
        {
           

        }

        public Bookclass(int id,string bookname,float price,string author)
        {
            this.Bookid = id;
            this.Bookname = bookname;
            this.Price = price;
            this.Author = author;
            

        }
        private int _bookid;
        public int Bookid
        {
            get
            {
                return _bookid;
            }
            set
            {
                _bookid = value;
            }
        }
        private string _bookname;
        public string Bookname
        {
            get { return _bookname; }
            set { _bookname = value; }
        }
        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }

        }
        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private int _noofpages;
        public int NoOfPages
        {
            get { return _noofpages; }
            set { _noofpages = value; }
        }


        public void InsertBook(int id,string name,float price)
        {
            this.Bookid = id;
            this.Bookname = name;
            this.Price = price;
            

        }



        public void InsertBook(int id, string name, float price,string author)
        {
            this.Bookid = id;
            this.Bookname = name;
            this.Price = price;
            this.Author = author;
           

        }

        public void InsertBook(int id, string name)
        {
            this.Bookid = id;
            this.Bookname = name;
        }


        

        
        






    }
}
