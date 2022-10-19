using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19thOctober2022
{
    public class Student
    {
        public enum CourseName
        {
            AIML,Dotnet,Java
        }
        public int RoolNo { get; set; }

        public string Name { get; set; }

        public CourseName courseName { get; set; }


    }
}
