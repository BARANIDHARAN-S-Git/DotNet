using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using products;

namespace category
{
    public class categoryClass
    {
       
        public categoryClass()
        {

        }
        public categoryClass(int caid, string caname)
        {
            categoryid = caid;
            categoryname = caname;

        }
        
        private int catid;
        public int categoryid
        {
            get { return catid; }
            set { catid = value; }
        }
        private string catname;
        public string categoryname
        {
            get { return catname; }
            set { catname = value; }

        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public void addcategory()
        {
            Console.WriteLine("Enter the category id : ");
            categoryid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Category Name : ");
            categoryname =Console.ReadLine();
            Console.WriteLine("Enter the Description : ");
            description = Console.ReadLine();
            Console.WriteLine(" ");

        }

       public static int cnt = 0;
        List<productsClass> products=new List<productsClass>();
        public void add(productsClass p)
        {
            products.Add(p);
            cnt++;

        }
        public void Displaydetails()
        {
            Console.WriteLine("Category Id : " + this.categoryid);
            Console.WriteLine("Category Name:" + this.categoryname);
            Console.WriteLine("Description : " + this.description);
            Console.WriteLine(" ");
            foreach(var p in products)
            {
                Console.WriteLine("Product ID : " + p.PId);
                Console.WriteLine("Product Name : " + p.PName);
                Console.WriteLine("Unit Price : " + p.Up);
                Console.WriteLine("Quantity sold : " + p.Qtysold);
                Console.WriteLine("Quantity in Hand : " + p.QntinHand);
                Console.WriteLine("Unit of Measurement : " + p.unitom);
                Console.WriteLine("ReorderLevel : " + p.rol);
                Console.WriteLine("  ");

                
            }
            

            Console.WriteLine(" ");
            Console.WriteLine("-----------------------");
        }
    

        

    }
}
