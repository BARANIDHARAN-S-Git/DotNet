using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thAugusr2022
{
    class stack
    {

        static void Main(string[] args)
        {

            int capacity;

            Console.WriteLine("Enter Capacity of Stack :");

            capacity = int.Parse(Console.ReadLine());



            MyStack<string> stack = new MyStack<string>(10);



            while (true)

            {

                Console.WriteLine("1.Push");

                Console.WriteLine("2.Pop");

                Console.WriteLine("3.Peep");

                Console.WriteLine("4.Print Stack Elements:");
               
                Console.WriteLine("5.Exit");

                



                Console.WriteLine("Eneter your Choice :");

                int choice = int.Parse(Console.ReadLine());



                switch (choice)

                {

                    case 1:

                        {

                            Console.WriteLine("Enter String to Push :");

                            string temp = Console.ReadLine();

                            int result = stack.push(temp);



                            if (result != -1)

                            {

                                Console.WriteLine("Element Pushed into Stack !");

                            }

                            else

                            {

                                Console.WriteLine("Stack Overflow !");

                            }

                            break;

                        }

                    case 2:

                        {

                            string Result = stack.pop();

                            if (Result != null)

                            {

                                Console.WriteLine("Delete Element :" + Result);

                            }

                            else

                            {

                                Console.WriteLine("Stack Underflow !");

                            }

                            break;

                        }



                    case 3:

                        {

                            Console.WriteLine("Enter Position of Element to Pop:");

                            int Position = int.Parse(Console.ReadLine());

                            string Result = stack.peep(Position);



                            if (Result != null)

                            {

                                Console.WriteLine("Element at Position" + Position + " is " + Result);

                            }

                            else

                            {

                                Console.WriteLine("Entered Element is Out of Stack Range ");

                            }

                            break;

                        }

                    case 4:

                        {

                            string[] Elements = stack.GetAllStackElements();

                            Console.WriteLine("__________________The Content in the stack are___________________");

                            foreach (string str in Elements)

                            {

                                Console.WriteLine(str);

                            }

                            break;

                        }

                    case 5:

                        {

                            System.Diagnostics.Process.GetCurrentProcess().Kill();

                            break;

                        }





                }

            }



        }

    }
}
