using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class AdminDiaconalController : Controller
    {
        // GET: AdminDiaconal
        public ActionResult AdminDiaconal()
        {
            TempData.Keep();
            return View();
        }
    }
}