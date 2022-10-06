using _6thOctober2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _6thOctober2022.Controllers
{
    public class productController : Controller
    {
        // GET: product
        static List<ProductModel> productlist = new List <ProductModel>();
        static productController()
        {
            productlist.Add(new ProductModel { productid = 1, productname = "Maaza", price = 50, Mfgdate = new DateTime(2022, 10, 06), Expdate = new DateTime(2022, 11, 06) });
            productlist.Add(new ProductModel { productid = 2, productname = "Bourbun", price = 40, Mfgdate = new DateTime(2022, 10, 03), Expdate = new DateTime(2022, 11, 03) });
            productlist.Add(new ProductModel { productid = 3, productname = "Bovanata", price = 70, Mfgdate = new DateTime(2022, 10, 02), Expdate = new DateTime(2022, 11, 03) });
            productlist.Add(new ProductModel { productid = 4, productname = "Lays", price = 20, Mfgdate = new DateTime(2022, 10, 01), Expdate = new DateTime(2022, 11, 01) });
            productlist.Add(new ProductModel { productid = 5, productname = "DarkFantasy", price = 100, Mfgdate = new DateTime(2022, 9, 08), Expdate = new DateTime(2022, 12, 08) });
        }
        public ActionResult Index()
        {
            return View(productlist);
        }

        public ActionResult Acceptdata()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Acceptdata(ProductModel model)
        {
            ProductModel p=new ProductModel();
            p.productid=model.productid;
            p.productname=model.productname;
            p.price=model.price;
            p.Mfgdate=model.Mfgdate;
            p.Expdate = model.Expdate;
            return View();
            
        }

        public ActionResult search(int id)
        {
            ProductModel foundata= productlist.Find(product => product.productid == id);
            return View(foundata);

        }
    }
}