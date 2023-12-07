using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaVanThy_DoAn_WebDoTheThaoNike.Identity;
using HaVanThy_DoAn_WebDoTheThaoNike.Filters;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class AccountAdminController : Controller
    {
        // GET: Admin/AccountAdmin
        public ActionResult Index()
        {
            AppDbContext db = new AppDbContext();
            List<AppUser> users = db.Users.ToList();
            return View(users);
        }
    }
}