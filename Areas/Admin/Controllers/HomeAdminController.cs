using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaVanThy_DoAn_WebDoTheThaoNike.Filters;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}