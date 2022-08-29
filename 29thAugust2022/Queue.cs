using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    
    class Queue
    {
        private int[] element;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            element = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                element[++rear] = item;
            }
        }

        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + element[front]);
                return element[front++];
            }
        }

        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(element[i]);
                }
            }
        }
      
       
    }
    
}
