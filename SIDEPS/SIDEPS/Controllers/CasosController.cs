using SIDEPS.WCFServices;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{

    public class CasosController : Controller
    {
        private readonly ICasosSvc casosSvc = new CasosSvcClient();

        // GET: Casos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InsertarCaso()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActionResult(SIDEPS_25REGCASO caso)
        {
            return View();
        }
    }
}