using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    
    public class Node<T>
    {
        internal Node<T> next;
        public T data;
        public Node(T data)
        {
            this.data = data;
        }
    }

    public class GenericLinkedList<T>
    {
        internal Node<T> head;
        public void InsertFront(GenericLinkedList<T> link, T data)
        {
            Node<T> newnode = new Node<T>(data);
            newnode.next = link.head;
            link.head = newnode;

        }
        public Node<T> GetLast(GenericLinkedList<T> link)
        {
            Node<T> last = link.head;
            while (last.next != null)
            {
                last = last.next;
            }
            return last;
        }
        public void InsertLast(GenericLinkedList<T> link, T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (link.head != null)
            {
                link.head = newnode;
                return;
            }
            Node<T> last = GetLast(link);

        }
        public void InsertAfter(Node<T> prevNode, T data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("This node cannot be null");
                return;
            }
            Node<T> newnode = new Node<T>(data);
            newnode.next = prevNode.next;
            prevNode.next = newnode;

        }
        public void Print(GenericLinkedList<T> link)
        {
            Node<T> temp = link.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
