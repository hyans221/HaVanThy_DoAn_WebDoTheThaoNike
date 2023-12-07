using HaVanThy_DoAn_WebDoTheThaoNike.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaVanThy_DoAn_WebDoTheThaoNike.Models;
//using HaVanThy_DoAn_WebDoTheThaoNike.Filters;
using System.Data.Entity;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class CategoriesAdminController : Controller
    {
        // GET: Admin/CategoriesAdmin
        NikeDBContext db = new NikeDBContext();
        public ActionResult Index()
        {
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                var existingCategory = db.Categories.FirstOrDefault(c => c.CategoryName.Equals(category.CategoryName, StringComparison.OrdinalIgnoreCase));
                if (existingCategory != null)
                {
                    ModelState.AddModelError("CategoryName", "A category with this name already exists.");
                    return View(category);
                }

                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public ActionResult Edit(int id)
        {
            var category = db.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                var existingCategory = db.Categories.FirstOrDefault(c => c.CategoryName.Equals(category.CategoryName, StringComparison.OrdinalIgnoreCase) && c.CategoryID != category.CategoryID);
                if (existingCategory != null)
                {
                    ModelState.AddModelError("CategoryName", "Another category with this name already exists.");
                    return View(category);
                }

                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public ActionResult Delete(int id)
        {
            var category = db.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var category = db.Categories.FirstOrDefault(c => c.CategoryID == id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}