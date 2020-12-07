using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class AdminParroquialController : Controller
    {
        // GET: AdminParroquial
        public ActionResult MenuParroquial()
        {
            TempData.Keep();
            return View();
        }
        public ActionResult MenuMantenimiento()
        {
            TempData.Keep();
            return View();
        }
        public ActionResult MenuHistorial()
        {
            TempData.Keep();
            return View();
        }
    }
}