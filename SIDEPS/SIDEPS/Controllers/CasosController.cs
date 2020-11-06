using SIDEPS.WCFCasos;
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

        public ActionResult Insertar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insertar(SIDEPS_25REGCASO caso)
        {
            return View();
        }
    }
}