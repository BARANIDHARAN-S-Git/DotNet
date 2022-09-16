using CustomerUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using Json.Net;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace _14thSeptember2022
{
    internal class Program
    {
        public static void xmlserialization()
        {
            FileStream fs2 = new FileStream("newsearchedmovies.xml", FileMode.Create, FileAccess.Write);
           
            User us = new User();
            us.userid = 9999888877;
            us.password = 123456789;
            us.validateUser();
            us.SearchBylanguageGenre("Tamil","Action");
            XmlSerializer xml = new XmlSerializer(typeof(User));
            xml.Serialize(fs2, us);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();
            fs2.Dispose();


        }
        public static void jsonserialization()
        {
            User us1 = new User();
            Movie m =new Movie();
            m.AddMovieDetails("Master", "Tamil", "Action", 400);
            us1.userid = 9999888877;
            us1.password = 123456789;
            us1.validateUser();
           us1.Movieborrowed(m);
            

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            StringBuilder s1=new StringBuilder();
            serializer.Serialize(us1, s1);
            Console.WriteLine(s1);
            FileStream fs = new FileStream("seemmovies.json", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(s1);

            fs.Flush();
            sw.Close();
            fs.Close();
        }

        public static void  soapserialize(Movie m)
        {
            User u = new User();

            u.userid = 9999888877;
            u.password = 123456789;
            u.validateUser();
            
            u.Movieborrowed(m);
            var dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("Movie 1 Availability " + m.Available);
           
            FileStream fs2 = new FileStream("borrowreturn.soap", FileMode.Create, FileAccess.Write);


            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(fs2, m.Available);
           
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();


        }
        public static void soapserialize1(Movie m)
        {
            User u = new User();

            u.userid = 9999888877;
            u.password = 123456789;
            u.validateUser();

            u.Movieborrowed(m);
            
            u.moviereturned(m, 2);
            var dt1 = new DateTime();
            dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            Console.WriteLine("Movie 1 Availability " + m.Available);
           

            FileStream fs3 = new FileStream("borrowreturn1.soap", FileMode.Create, FileAccess.Write);


            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(fs3, m.Available);

            fs3.Flush();
            fs3.Close();
            fs3.Dispose();


        }
        public static void binaryserialization()
        {
            User u = new User();

            u.userid = 9999888877;
            u.password = 123456789;
            u.validateUser();
            FileStream fs = new FileStream(@"userrecord.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, u);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("---------------------------------------------");
            User us1 = new User();
            us1.userid = 12456789;
            us1.password = 9999888877;
            us1.validateUser();
            FileStream fs1 = new FileStream(@"userrecord1.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter.Serialize(fs1, us1);
            fs1.Flush();
            fs1.Close();
            fs1.Dispose();
        }
       
        public static void binaryserialization1()
        {
            User u = new User();
            Movie m1 = new Movie();
            m1.AddMovieDetails("Master", "Tamil", "Action", 400);

            u.userid = 9999888877;
            u.password = 123456789;
            u.validateUser();
            var present= DateTime.Now;
           
           var borrowed = new DateTime(2022, 09, 13);

            var  diff = present - borrowed;
            int a=diff.Days;

            u.Movieborrowed(m1);
            u.moviereturned(m1,a);
            FileStream fs = new FileStream(@"amount.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, u);
            fs.Flush();
            fs.Close();
            fs.Dispose();
           
        }
        static void Main(string[] args)
        {
           
            //-----------------------------------------------------------------------
        


           


            Console.WriteLine("------------------------------------");

            

            Movie m1 = new Movie();
            m1.AddMovieDetails("Master", "Tamil", "Action", 400);
            Movie m2 = new Movie();
            m2.AddMovieDetails("Doctor", "Tamil", "comedy", 75);
            Movie m3 = new Movie();
            m3.AddMovieDetails("DJ", "Telugu", "Action", 90);
            Movie m4 = new Movie();
            m4.AddMovieDetails("Pushpa", "Telugu", "Thriller", 40);
            Movie m5 = new Movie();
            m5.AddMovieDetails("The Gray Man", "English", "Action", 100);



            User u1 = new User();
            User u2 = new User();
            User u3 = new User();
            User u4 = new User();
            User u5 = new User();

            u2.usertoadd("Silver");
            binaryserialization();
            binaryserialization1();


            xmlserialization();
            jsonserialization();
            soapserialize(m1);
            soapserialize(m1);
            Console.ReadLine();



        }




    }
}

