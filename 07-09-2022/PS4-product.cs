using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

	public delegate void idname();
    public class PS4_product
    {
		private int id;

		public int productid
		{
			get { return id; }
			set { id = value; }
		}

		public string name;

		public string productname
		{
			get { return name; }
			set { name = value; }
		}

		public void printidname()
		{
			Console.WriteLine("Product Id : " + this.id + " " + "Product Name : " + this.name);
		}


	}
}
