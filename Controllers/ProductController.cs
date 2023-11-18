using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaVanThy_DoAn_WebDoTheThaoNike.Models;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        NikeDBContext db = new NikeDBContext();
        public ActionResult Index()
        {
            
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public ActionResult Detail(int id)
        {
            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            return View(product);
        }

    }
}