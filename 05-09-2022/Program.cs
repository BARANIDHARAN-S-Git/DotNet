using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book;




namespace _5thSeptember2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Bookclass b=new Bookclass();
            b.InsertBook(1,"You can win",123);
            Bookclass b1 = new Bookclass();
            b1.InsertBook(2, "Way to success", 200, "Robert");
            Bookclass b2 = new Bookclass();
            b2.InsertBook(3, "Be Positive");

            Cartclass c=new Cartclass();
            c.Addtocart(b);
            c.Addtocart(b1);
            c.Addtocart(b2);
            c.printbooks();
        }
    }
}
