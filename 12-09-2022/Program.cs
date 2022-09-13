using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _12thSeptember2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\brother\source\repos\calculator\bin\Debug\calculator.dll";
            Assembly asm = Assembly.LoadFrom(path);

            Type[] types = asm.GetTypes();
            Type t = null;

            foreach (var item in types)
            {
                Console.WriteLine("name= " + item.Name);
                Console.WriteLine("Full Name= " + item.FullName);

                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Absatract=" + item.IsAbstract);
                Console.WriteLine("Whether public " + item.IsPublic);


                Console.WriteLine("-------------------------------------------------------");
                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);
                
                

                item.InvokeMember("read", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] {4});
                item.InvokeMember("cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);

                item.InvokeMember("sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] {9});

               
                Console.ReadLine();

            }
        }
    }
}

