using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _9thSeptember2022
{
    public  class Threadclass
    {
        public static void first()
        {
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" first={0}", i);
                if (i == 5)
                {
                    Thread.Sleep(1000);
                }


            }
        }

        public static void second()
        {
            
            
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Second ={0}", j);
            }
        }

       

        static void Main(string[] args)
        {
          

            Thread t1 = new Thread(first);
            Thread t2 = new Thread(second);
            
          

            t1.Start();
            t2.Start();
            

            Console.ReadLine();
        }
    }
}
