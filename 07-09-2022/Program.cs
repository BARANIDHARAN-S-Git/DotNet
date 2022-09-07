using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Delegate;

namespace _7thSeptember2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------PS1---------------------");
            PS1 first = new PS1();

            lengthdelegate l = new lengthdelegate(first.length);
            l.Invoke("Alex");
            Console.WriteLine(" ");
            Console.WriteLine("--------------PS2---------------------");
            PS2 second=new PS2();
            printusername p = new printusername(second.print);
            p.Invoke("Buttler");


            Console.WriteLine(" ");
            Console.WriteLine("--------------PS3---------------------");
            PS3 fourth = new PS3();
            addsubmultiply[] asm = new addsubmultiply[3] { fourth.sum, fourth.subtract, fourth.multiply };
             addsubmultiply asm1=(addsubmultiply)MulticastDelegate.Combine(asm);
             asm1.Invoke(3,2);

            Console.WriteLine(" ");
            Console.WriteLine("--------------PS4---------------------");
            PS4_product sixth=new PS4_product();
            
            sixth.productid = 101;
            sixth.productname = "Mango";
            idname i = new idname(sixth.printidname);
            i.Invoke();

            Console.WriteLine(" ");
            Console.WriteLine("--------------PS5---------------------");
            PS5_Employee seventh = new PS5_Employee();
            seventh.joiningyear = 2000;
            jyear j=new jyear(seventh.yearofservice);
            j.Invoke();



            Console.WriteLine(" ");
            Console.WriteLine("--------------PS6---------------------");
            PS6 eigth = new PS6();
            concatenate c = new concatenate(eigth.conc);
            string ans =c.Invoke("Jason", "Roy");
            Console.WriteLine(ans);


            Console.WriteLine(" ");
            Console.WriteLine("--------------PS7---------------------");
            PS7 ninth = new PS7();

            uppercase u = new uppercase(ninth.upper);
            string up=u.Invoke("axarpatel");
            
            Console.WriteLine(up);
            






            Console.ReadLine();
        }
    }
}
