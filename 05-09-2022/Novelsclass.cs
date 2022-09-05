using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{

    public class Novelsclass:Bookclass
    {


        public void InsertBook(int id,string name,float price,int nop)
        {
            this.Bookid = id;
            this.Bookname = name;
           this. Price = price;
            this.NoOfPages = nop;
        }

        public new void InsertBook(int id, string name, float price)
        {
            this.Bookid = id;
            this.Bookname = name;
            this.Price = price;

        }
       
    }
}
