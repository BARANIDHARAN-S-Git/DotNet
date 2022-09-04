using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class productsClass
    {

        public productsClass()
        {

        }
        public productsClass(int prodid, string prodname,int unp,int qns,int qnih,string uom,string reolevel)
        {
            PId = prodid;
            PName = prodname;
            Up=unp;
            Qtysold=qns;
            QntinHand=qnih;
            rol=reolevel;
            unitom=uom;
            

        }




        private int productid;
        public int PId
        {
            get { return productid; }
            set { productid = value; }
        }
        private string productname;
        public string PName
        { get { return productname; } set { productname = value; } }
        private int qntysold;
        public int Qtysold
        {
            get { return qntysold; }
            set { qntysold = value; }
        }
        private int unitprice;
        public int Up
        { get { return unitprice; } set { unitprice = value; } }
        private string unitofmeasurement;
        public string unitom
        {
            get
            {
                return unitofmeasurement;
            }
            set { unitofmeasurement = value; }
        }
        private int qntyinhand;
        public int QntinHand
        {
            get
            {
                return qntyinhand;
            }
            set
            {
                qntyinhand = value;
            }
        }
        private string reorderlevel;
        public string rol
        {
            get
            {
                return reorderlevel;
            }
            set
            {
                reorderlevel = value;
            }
        }


        public void Addproduct()
        {
            Console.WriteLine("Enter the product ID");

            PId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product name");
            PName = Console.ReadLine();
            Console.WriteLine("Enter the unit price for this product : " + PName);
            Up = Convert.ToInt32(Console.ReadLine());       

            
            Console.WriteLine("Enter Quantity sold : ");
            Qtysold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity in Hand : ");
            QntinHand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Unit of Measurement : ");
            unitom = Console.ReadLine();
            Console.WriteLine("Enter ReorderLevel : " );
            rol=Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("----------------");

           
            

        }
    }
}
