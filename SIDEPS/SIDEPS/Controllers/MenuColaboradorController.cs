using SIDEPS.Models;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class MenuColaboradorController : Controller
    {
        // GET: MenuColaborador
        public ActionResult MenuColaborador()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
    }
}