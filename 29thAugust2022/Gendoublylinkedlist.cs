using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    public class Dnode<T>
    {
        public T data;
        internal Dnode<T> next;
        internal Dnode<T> prev;
        public Dnode(T data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;

        }
    }

    public class Dlink<T>
    {
        internal Dnode<T> head;
        internal Dnode<T> tail;
        public void InsertFront(Dlink<T> link, T data)
        {
            Dnode<T> newnode = new Dnode<T>(data);
            newnode.next = link.head;
            link.head = newnode;
            newnode.prev = null;
            if (link.head != null)
            {
                link.head.prev = newnode;
            }
            link.head = newnode;
        }
        public Dnode<T> GetLast(Dlink<T> link)
        {
            Dnode<T> last = link.head;
            while (last.next != null)
            {
                last = last.next;
            }
            return last;
        }
        public void InsertLast(Dlink<T> link, T data)
        {
            Dnode<T> newnode = new Dnode<T>(data);
            if (link.head == null)
            {

                link.head = newnode;
                link.tail = newnode;
                return;
            }
            Dnode<T> lastNode = GetLast(link);
            lastNode.next = newnode;
            newnode.prev = lastNode;
        }
        public void DeleteKey(Dlink<T> link, T key)
        {
            Dnode<T> temp = link.head;
            if (temp != null && temp.data.Equals(key))
            {
                link.head = temp.next;
                link.head.prev = null;
                return;
            }
            while (temp != null && !temp.data.Equals(key))
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }
        public void Print(Dlink<T> link)
        {
            Dnode<T> temp = link.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(" ");
            Console.WriteLine("---------------------");
        }

    }

}
