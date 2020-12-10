using SIDEPS.Models;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class AdminParroquialController : Controller
    {
        // GET: AdminParroquial
        public ActionResult MenuParroquial()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            return View();
        }

        public ActionResult MenuMantenimiento()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            return View();
        }

        public ActionResult MenuHistorial()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            return View();
        }
    }
}