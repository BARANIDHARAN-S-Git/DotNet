using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    class MyStack<T>
    {
        int capacity;
        T[] stack;
        int top;

        public MyStack(int MaxElements)

        {

            capacity = MaxElements;

            stack = new T[capacity];



            

        }



        public int push(T Element)

        {

            

            if (top == capacity - 1)

            {

                

                return -1;

            }

            else

            {

                

                top = top + 1;

                stack[top] = Element;

            }

            return 0;

        }



        public T pop()

        {

            T RemovedElement;

            T temp = default(T);

            

            if (!(top <= 0))

            {

                RemovedElement = stack[top];

                top = top - 1;

                return RemovedElement;

            }

            return temp;



        }



        public T peep(int position)

        {

            T temp = default(T);

            

            if (position < capacity && position >= 0)

            {

                return stack[position];

            }

            return temp;

        }



        public T[] GetAllStackElements()

        {

            T[] Elements = new T[top + 1];

            Array.Copy(stack, 0, Elements, 0, top + 1);

            return Elements;

        }

    }
}
