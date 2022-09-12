using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static _12thSeptember2022.song;

namespace _12thSeptember2022
{
    public class CustomAttributes
    {

        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("class " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  

             
            foreach (System.Attribute attr in attrs)
            {
                if (attr is stereodisc)
                {
                    stereodisc d = (stereodisc)attr;
                    Console.WriteLine("name" + attr);
                    Console.WriteLine("  ");
                    Console.WriteLine("Song Name :"+d.songname+"\n"+"Language : "+d.songlanguage+"\n"+"Lyrics : "+d.songlyrics);
                    Console.WriteLine("  ");
                }
            }
           
            MemberInfo[] minfo = t.GetMembers();


            foreach (var item in minfo)
            {
                Console.WriteLine("Name : " + item.Name);
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is stereodisc)
                    {
                        stereodisc d = (stereodisc)attrItem;
                        Console.WriteLine();
                        System.Console.WriteLine("Song Name :" + d.songname + "\n" + "Language : " + d.songlanguage + "\n" + "Lyrics : " + d.songlyrics);
                        Console.WriteLine("  ");
                    }
                }

            }


        }
        static void Main(string[] args)
        {

            CustomAttributes.WritedataForEachCode(typeof(song));
            Console.Read();
        }
    }
}
