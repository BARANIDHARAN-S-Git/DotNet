using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    internal class Doublylinkedlist
    {
        static void Main(string[] args)
        {
            Dlink<int> d = new Dlink<int>();
            d.InsertFront(d, 234);
            d.InsertLast(d, 300);
            d.InsertLast(d, 435);
            d.InsertLast(d, 567);
            d.InsertLast(d, 600);
            d.Print(d);
            Console.WriteLine(" ");
            d.DeleteKey(d, 567);
            d.Print(d);
            Console.WriteLine("");
            d.DeleteKey(d, 300);
            d.Print(d);
            Console.WriteLine("");
        }
    }
}
