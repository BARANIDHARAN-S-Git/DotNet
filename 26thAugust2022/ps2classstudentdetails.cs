using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26thAugust2022
{
    public class studentdetails
    {
        public int id;
        public string Name;
        public int Age;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

    }
}
