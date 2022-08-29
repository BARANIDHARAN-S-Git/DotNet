using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    internal class SinglyLinkedList
    {
        static void Main(string[] args)
        
            {
                GenericLinkedList<int> gsl = new GenericLinkedList<int>();
                gsl.InsertFront(gsl, 45);
                gsl.InsertFront(gsl, 55);
                gsl.InsertFront(gsl, 65);
                gsl.InsertFront(gsl, 75);
                gsl.Print(gsl);
                gsl.InsertLast(gsl, 123);
                gsl.Print(gsl);
            
            }
        
    }
}
