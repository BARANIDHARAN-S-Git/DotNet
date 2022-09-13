using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using usermodule;

namespace _13thSeptember2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            


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
          

            u2.AddUser("Vel", "Murugan", "Silver");
            u3.AddUser("Chiranjeevi", "Saravanan", "Gold");
            u4.AddUser("Prakah", "Murugan", "Platinum");
            u5.AddUser("Dinesh", "Kumar", "Silver");
           
            
            u2.Movieborrowed(m1);
            u4.Movieborrowed(m1);
            Console.WriteLine("Movie 1 Availability " + m1.Available);
            u2.RetrunMovie(m1, 4);
            Console.WriteLine("Movie 1 Availability " + m1.Available);
            u3.Movieborrowed(m1);
           
            u5.Movieborrowed(m1);
          
            u1.Movieborrowed(m2);
            u1.RetrunMovie(m2, 5);
            u1.Movieborrowed(m3);
            Console.WriteLine("-----------------------------------------------------------------");
            u1.ShowMyList();
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Based on Language");
            u1.SearchByLanguage("Tamil");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Based on genre");
            u1.SearchByGenre("Action");
            


        }
    }

        
    
}
