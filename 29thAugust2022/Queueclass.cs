using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    internal class Queueclass
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue(5);

            Q.Enqueue(15);
            Q.Enqueue(24);
            Q.Enqueue(32);
            Q.Enqueue(68);
            Q.Enqueue(72);


            Console.WriteLine("After Enqueue : ");
            Q.printQueue();

            Q.Dequeue();
            Q.Dequeue();

            Console.WriteLine("After Dequeue : ");
            Q.printQueue();
        }
    }
}
