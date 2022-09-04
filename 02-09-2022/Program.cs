using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using category;
using products;

namespace _2ndseptember2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            productsClass pc1 = new productsClass();
            pc1.Addproduct();
            productsClass pc2 = new productsClass();
            pc2.Addproduct();

            categoryClass cc = new categoryClass();
            cc.addcategory();
            cc.add(pc1);
            cc.add(pc2);
            


            productsClass pc3 =new productsClass();
            pc3.PId = 1;
            pc3.PName = "Maaza";
            pc3.QntinHand = 500;
            pc3.Qtysold = 200;
            pc3.Up = 50;
            pc3.unitom ="NOS";
            pc3.rol = "LOW";
           
            productsClass pc4 = new productsClass();
            pc4.PId = 2;
            pc4.PName = "Frooti";
            pc4.QntinHand = 400;
            pc4.Qtysold = 100;
            pc4.Up = 30;
            pc4.unitom = "NOS";
            pc4.rol = "LOW";


            productsClass pc5 = new productsClass(3,"Bovento",35,345,125,"NOS","LOW");
          

            categoryClass cc1 = new categoryClass();
            cc1.categoryid = 101;
            cc1.categoryname = "Beverages";
            cc1.Description = "A drink for Refreshment";
            cc1.add(pc3);
            cc1.add(pc4);
            cc1.add(pc5);
            

            
            
            cc.Displaydetails();
            cc1.Displaydetails();



           


            Console.WriteLine("Total Products: " + categoryClass.cnt);







        }
    }
}
