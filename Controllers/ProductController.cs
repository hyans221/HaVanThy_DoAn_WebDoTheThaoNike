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
        public ActionResult Index(string sortOrder = "", string category = "", string gender = "", int page = 1)
        {

            List<Product> products = db.Products.ToList();

            // Category Page
            if (!String.IsNullOrEmpty(category))
            {
                if (category.Equals("Shoes", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.Where(p => p.Category.CategoryName.Contains("Shoes")).ToList();
                }
                else
                {
                    products = products.Where(p => p.Category.CategoryName.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
                }
            }


            // Gender Category Page
            if (!String.IsNullOrEmpty(gender))
            {
                switch (gender.ToLower())
                {
                    case "men":
                        products = products.Where(p => p.Category.CategoryName.Equals("Men's Shoes", StringComparison.OrdinalIgnoreCase)).ToList();
                        break;
                    case "women":
                        products = products.Where(p => p.Category.CategoryName.Equals("Women's Shoes", StringComparison.OrdinalIgnoreCase)).ToList();
                        break;
                    case "kid":
                        products = products.Where(p => p.Category.CategoryName.Equals("Older Kids' Shoes", StringComparison.OrdinalIgnoreCase)).ToList();
                        break;
                }
            }


            //Sort
            switch (sortOrder)
            {
                case "PriceDesc":
                    products = products.OrderByDescending(p => p.Price).ToList();
                    break;
                case "PriceAsc":
                    products = products.OrderBy(p => p.Price).ToList();
                    break;
                default:
                    break;
            }

            //Paging
            int NoOfRecordPerPage = 8;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(products.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.NoOfPages = NoOfPages;
            products = products.Skip(NoOfRecordToSkip).Take(NoOfRecordPerPage).ToList();

            return View(products);
        }

        public ActionResult Detail(int id)
        {
            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            return View(product);
        }
    }
}