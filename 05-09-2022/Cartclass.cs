using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Cartclass:Bookclass
    {
        private int _customerid;
        public int Customerid
        {
            get { return _customerid; }
            set { _customerid = value; }
        }
        private int _bookingid;
        public int Bookingid
        {
            get { return _bookingid; }
            set { _bookingid = value; }
        }

        public static int count=0;
        List<Bookclass>l=new List<Bookclass>();
        public void Addtocart(Bookclass b)
        {
            l.Add(b);
            count++;

        }

        public void printbooks()
        {
            
            Console.WriteLine("Enter the Customer id :");
            Customerid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Booking id :");
            Bookingid = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("-----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Customer Id: " + Customerid);
            Console.WriteLine("Booking Id: " + Bookingid);
            Console.WriteLine(" ");
            foreach(var items in l)
            {
                
                Console.WriteLine("Book Id :" +items.Bookid);
                Console.WriteLine("Book Name: " + items.Bookname);
                Console.WriteLine("Price: " + items.Price);
                Console.WriteLine("Author: " + items.Author);
                Console.WriteLine("No Of Pages : "+items.NoOfPages);
                Console.WriteLine(" ");
                Console.WriteLine("-----------------");

            }

            Console.WriteLine("No Of Books Added to the Cart is : " + count);
        }
    }
}
