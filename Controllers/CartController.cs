using HaVanThy_DoAn_WebDoTheThaoNike.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Controllers
{
    public class CartController : Controller
    {
        NikeDBContext db = new NikeDBContext();
        // GET: Cart
        public ActionResult Index()
        {
            List<CartItem> cartItems = db.CartItems.ToList();

            return View(cartItems);
        }

        public ActionResult Add(int id = 0)
        {
            try
            {
                if (id > 0)
                {
                    CartItem cartItem = db.CartItems.Where(cartItems => cartItems.ProductID == id).FirstOrDefault();
                    if (cartItem != null)
                    {
                        cartItem.Quantity += 1;
                        cartItem.DateCreated = DateTime.Now;
                    }
                    else
                    {
                        CartItem newCartItem = new CartItem();
                        newCartItem.ProductID = id;
                        newCartItem.Quantity = 1;
                        newCartItem.DateCreated = DateTime.Now;

                        db.CartItems.Add(newCartItem);
                    }
                    db.SaveChanges();
                    TempData["SuccessMessage"] = "Products added to cart successfully!";
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }

                var innerException = ex.InnerException;
                while (innerException != null)
                {
                    System.Diagnostics.Debug.WriteLine("Inner Exception: " + innerException.Message);
                    System.Diagnostics.Debug.WriteLine("Inner Exception Stack Trace: " + innerException.StackTrace);
                    innerException = innerException.InnerException;
                }

                TempData["ErrorMessage"] = "An error occurred while adding a product to the cart!";
            }
            return RedirectToAction("Index");
        }


        public ActionResult UpdateQuantity(int quantity = 0, int proid = 0)
        {
            if (quantity >= 0)
            {
                CartItem cartItem = db.CartItems.Where(c => c.ProductID == proid).FirstOrDefault();
                if (cartItem != null)
                {
                    cartItem.Quantity = quantity;
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int id)
        {
            CartItem cartItem = db.CartItems.Where(c => c.ProductID == id).FirstOrDefault();
            if (cartItem != null)
            {
                db.CartItems.Remove(cartItem);
                db.SaveChanges();
                TempData["SuccessMessage"] = "The product has been removed from the cart successfully!";
            }
            return RedirectToAction("Index");
        }


    }
}
