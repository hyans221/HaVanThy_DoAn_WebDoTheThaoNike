using HaVanThy_DoAn_WebDoTheThaoNike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaVanThy_DoAn_WebDoTheThaoNike.Models;
using System.Data.Entity;
using HaVanThy_DoAn_WebDoTheThaoNike.Filters;
using System.IO;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class ProductAdminController : Controller
    {
        // GET: Admin/ProductAdmin
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

        public ActionResult Create()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = db.Products.FirstOrDefault(p => p.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase));
                if (existingProduct != null)
                {
                    ModelState.AddModelError("ProductName", "A product with this name already exists.");
                    ViewBag.Categories = db.Categories.ToList();
                    return View(product);
                }

                if (imageFile != null && imageFile.ContentLength > 0)
                {
                    if (imageFile.ContentLength > 2000000)
                    {
                        ModelState.AddModelError("Image", "File size must be less than 2MB.");
                        ViewBag.Categories = db.Categories.ToList();
                        return View(product);
                    }

                    var allowEx = new[] { ".jpg", ".png" };
                    var fileEx = Path.GetExtension(imageFile.FileName).ToLower();
                    if (!allowEx.Contains(fileEx))
                    {
                        ModelState.AddModelError("Image", "Only jpg or png image files.");
                        ViewBag.Categories = db.Categories.ToList();
                        return View(product);
                    }

                    var fileName = Guid.NewGuid().ToString() + fileEx; 
                    var directoryPath = Server.MapPath("~/images/imgShoes/");
                    var path = Path.Combine(directoryPath, fileName);
                    imageFile.SaveAs(path);

                    product.Image = fileName;
                }
                else
                {
                    product.Image = "default.png";
                }

                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = db.Categories.ToList();
            return View(product);
        }


        public ActionResult Edit(int id)
        {

            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();

            ViewBag.Categories = db.Categories.ToList();

            return View(product);
        }


        [HttpPost]
        public ActionResult Edit(Product pro, HttpPostedFileBase imageFile)
        {
            Product product = db.Products.FirstOrDefault(row => row.ProductID == pro.ProductID);

            if (product != null)
            {
                if (ModelState.IsValid)
                {
                    var existingProduct = db.Products.FirstOrDefault(p => p.ProductName.Equals(pro.ProductName, StringComparison.OrdinalIgnoreCase) && p.ProductID != pro.ProductID);
                    if (existingProduct != null)
                    {
                        ModelState.AddModelError("ProductName", "Another product with this name already exists.");
                        ViewBag.Categories = db.Categories.ToList();
                        return View(pro);
                    }

                    if (imageFile != null && imageFile.ContentLength > 0)
                    {
                        if (imageFile.ContentLength > 2000000)
                        {
                            ModelState.AddModelError("Image", "File size must be less than 2MB.");
                            ViewBag.Categories = db.Categories.ToList();
                            return View(pro);
                        }

                        var allowEx = new[] { ".jpg", ".png" };
                        var fileEx = Path.GetExtension(imageFile.FileName).ToLower();
                        if (!allowEx.Contains(fileEx))
                        {
                            ModelState.AddModelError("Image", "Only jpg or png image files.");
                            ViewBag.Categories = db.Categories.ToList();
                            return View(pro);
                        }

                        var fileName = Guid.NewGuid().ToString() + fileEx;
                        var directoryPath = Server.MapPath("~/images/imgShoes/");
                        var path = Path.Combine(directoryPath, fileName);
                        imageFile.SaveAs(path);

                        product.Image = fileName; 
                    }

                    product.ProductName = pro.ProductName;
                    product.Price = pro.Price;
                    product.Description = pro.Description;
                    product.CategoryID = pro.CategoryID;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return HttpNotFound();
            }

            ViewBag.Categories = db.Categories.ToList();
            return View(pro);
        }




        public ActionResult Delete(int id)
        {
            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(int id, Product p)
        {
            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}