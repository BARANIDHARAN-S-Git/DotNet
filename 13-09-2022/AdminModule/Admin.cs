using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usermodule;


namespace AdminModule
{
    public class Admin : User
    {
        public void ad()
        {
            Movie m=new Movie();
            //m.print();

            
            m.addadmin("SiliconValley");
            Console.WriteLine("Admin Added Movie successfully");
            m.print();
            Console.WriteLine("------------------------------");
            m.delete("DJ");
            Console.WriteLine("Admin Deleted Movie successfully");
            m.print();
            Console.WriteLine("Admin updated movie successfully");
            m.update("Master");
            m.print();

          

        }
        public Admin()
        {
            
            User.permission += allowornot;
        }
        public static bool allowornot(string s)
        {
            Console.WriteLine("ADMIN : Enter you Accept or not press 1 to accept");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input==1)
            {
                return true;
            }
            
            else
            {
               return false;
            }
        }



    }
}
