using SIDEPS.Models;
using SIDEPS.WCFCasos;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{

    public class CasosController : Controller
    {
        private const string _CEDULAPERSONA = "cedulaPersona";
        private const string _CODIGOCASO = "codigoCaso";

        private readonly ICasosSvc casosSvc = new CasosSvcClient();

        // GET: Casos
        public ActionResult Index()
        {
            return View(new List<Caso_M>());
        }

        public ActionResult Insertar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insertar(SIDEPS_25REGCASO caso)
        {
            return RedirectToAction("Index");
        }

        public ActionResult DatosPersonales()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DatosPersonales(Persona_M persona)
        {
            var resultadoP = this.casosSvc.SP_Ins_Persona(persona.ConvertirEntidad());
            if (resultadoP)
            {
                var caso = new Caso_M
                {
                    CEDPERS13 = persona.CEDPERS13
                };

                var resultadoC = this.casosSvc.SP_Ins_Caso(caso.ConvertirEntidad());
                if (resultadoC)
                {
                    TempData[_CEDULAPERSONA] = persona.CEDPERS13;

                    return RedirectToAction("AspectoSalud");
                }
            }
            return View(persona);
        }

        public ActionResult AspectoSalud()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult AspectoSalud(AspectoSalud_M aspecto)
        {
            aspecto.CEDPERS13 = TempData[_CEDULAPERSONA].ToString();
            TempData.Keep();

            var resultado = this.casosSvc.SP_Ins_AspectoSalud(aspecto.ConvertirEntidad());
            if (resultado)
            {
                return RedirectToAction("Vivienda");
            }
            else
            {
                return View(aspecto);
            }
        }

        public ActionResult Vivienda()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult Vivienda(Vivienda_M vivienda)
        {
            TempData.Keep();

            return RedirectToAction("ProblemasSociales");

            return View(vivienda);
        }

        public ActionResult ProblemasSociales()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult ProblemasSociales(ProblemasSociales_M problemasSociales)
        {
            TempData.Keep();

            return RedirectToAction("SituacionFinanciera");

            return View(problemasSociales);
        }

        public ActionResult SituacionFinanciera()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult SituacionFinanciera(SituacionFinanciera_M situacionFinanciera)
        {
            TempData.Keep();

            return RedirectToAction("EgresosMensuales");

            return View(situacionFinanciera);
        }

        public ActionResult EgresosMensuales()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult EgresosMensuales(EgresosMensuales_M egresosMensuales)
        {
            TempData.Keep();

            return RedirectToAction("MotivoSolicitud");

            return View(egresosMensuales);
        }

        public ActionResult MotivoSolicitud()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult MotivoSolicitud(MotivoSolicitud_M motivoSolicitud)
        {
            TempData.Keep();

            return RedirectToAction("Index", "Home");

            return View(motivoSolicitud);
        }
    }
}