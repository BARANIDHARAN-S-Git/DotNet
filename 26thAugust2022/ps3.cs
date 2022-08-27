using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _26thAugust2022
{
    internal class ps3
    {

        class products
        {
            private int _productID;

            public int ProductID
            {
                get { return _productID; }
                set { _productID = value; }
            }
            private string _productname;

            public string Productname
            {
                get { return _productname; }
                set { _productname = value; }
            }


        }

        static void Main(string[] args)
        {
            List<products> mylist = new List<products>();
            int n;
            Console.WriteLine("Enter the no of products to be add");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                addproduct(mylist);
            }
            displayproduct(mylist);

            removeproduct(mylist);
            displayproduct(mylist);




        }
       


        
        

        private static void addproduct(List<products> mylist)
        {
            products myproduct = new products();
            Console.WriteLine("Enter the product ID");
            myproduct.ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product name");
            myproduct.Productname=Console.ReadLine();
            mylist.Add(myproduct);
        }
        private static void displayproduct(List<products> mylist)
        {
            foreach (var item in mylist)
            {
                Console.WriteLine(item.ProductID);
                Console.WriteLine(item.Productname);
                Console.WriteLine(" ");
            }
        }
        private static void removeproduct(List<products> mylist)
        {
            Console.WriteLine("Enter the product id to remove");
            int id;
            id = Convert.ToInt32(Console.ReadLine());


            products s = mylist.Find(a => a.ProductID == id);


            mylist.Remove(s);
            Console.WriteLine("Removed successfully");
            Console.WriteLine(" ");
            Console.WriteLine("The remaining product available is :");

        }






    }
    
    }





