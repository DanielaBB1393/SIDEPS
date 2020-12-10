using SIDEPS.Models;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class AdminDiaconalController : Controller
    {
        // GET: AdminDiaconal
        public ActionResult AdminDiaconal()
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