using SIDEPS.Models;
using SIDEPS.WCFCasos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class CasosController : Controller
    {
        private const string _CODIGOCASO = "codigoCaso";
        private const string _CEDULAPERSONA = "cedulaPersona";
        private const string _CODIGOVIVIENDA = "codigoVivienda";

        private readonly ICasosSvc casosSvc = new CasosSvcClient();

        // GET: Casos
        public ActionResult Index()
        {
            return View(new List<Caso_M>());
        }

        //-------
        // Paso 1
        //-------
        public ActionResult DatosPersonales()
        {
            DatosPersonales_M modelo = new DatosPersonales_M
            {
                Religiones = this.casosSvc.SP_Con_Religiones().Select(r => new Categoria { Codigo = r.CODRELG11, Descripcion = r.DESRELG11 }).ToList(),
                Cantones = this.casosSvc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList(),
            };
            return View(modelo);
        }

        [HttpPost]
        public ActionResult DatosPersonales(DatosPersonales_M persona)
        {
            var resultadoP = this.casosSvc.SP_Ins_Persona(persona.ConvertirEntidad());
            if (resultadoP)
            {
                var caso = new Caso_M
                {
                    CEDPERS13 = persona.CEDPERS13
                };

                var resultadoC = this.casosSvc.SP_Ins_Caso(caso.ConvertirEntidad());
                if (resultadoC > 0)
                {
                    TempData[_CEDULAPERSONA] = persona.CEDPERS13;
                    TempData[_CODIGOCASO] = resultadoC;

                    return RedirectToAction("AspectoSalud");
                }
            }
            return View(persona);
        }

        //-------
        // Paso 2
        //-------
        public ActionResult AspectoSalud()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult AspectoSalud(AspectoSalud_M aspecto)
        {
            aspecto.CEDPERS13 = TempData[_CEDULAPERSONA].ToString();
            int codigoCaso = Convert.ToInt32(TempData[_CODIGOCASO].ToString());
            TempData.Keep();

            var resultado = this.casosSvc.SP_Ins_AspectoSalud(aspecto.ConvertirEntidad(), codigoCaso);
            if (resultado > 0)
            {
                return RedirectToAction("Vivienda");
            }
            else
            {
                return View(aspecto);
            }
        }

        //-------
        // Paso 3
        //-------
        public ActionResult Vivienda()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult Vivienda(Vivienda_M vivienda)
        {
            int codigoCaso = Convert.ToInt32(TempData[_CODIGOCASO].ToString());
            TempData.Keep();

            var resultado = this.casosSvc.SP_Ins_Vivienda(vivienda.ConvertirEntidad(), codigoCaso);

            if (resultado > 0)
            {
                TempData[_CODIGOVIVIENDA] = resultado;
                return RedirectToAction("GrupoFamiliar");
            }

            return View(vivienda);
        }

        //-------
        // Paso 4
        //-------
        public ActionResult GrupoFamiliar()
        {
            TempData.Keep();

            var model = new GrupoFamiliar_M
            {
                GrupoFamiliar = new List<MiembroFamiliar_M> { new MiembroFamiliar_M() }
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult GrupoFamiliar(GrupoFamiliar_M model)
        {
            var cedulaSolicitante = TempData[_CEDULAPERSONA].ToString();
            TempData.Keep();

            var nuevoFamiliar = model.GrupoFamiliar.Last();
            var resultado = this.casosSvc.SP_Ins_GrupoFamiliar(nuevoFamiliar.ConvertirEntidad(), cedulaSolicitante);
            if (!resultado)
            {
                ViewData["mensaje"] = "Ocurrió un error agregando a " + nuevoFamiliar.NOMFAML22;
            }
            model.GrupoFamiliar.Add(new MiembroFamiliar_M());

            return View(model);
        }

        //-------
        // Paso 5
        //-------
        public ActionResult Egresos()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult Egresos(Egresos_M egresosMensuales)
        {
            int codigoCaso = Convert.ToInt32(TempData[_CODIGOCASO].ToString());
            TempData.Keep();

            var resultado = this.casosSvc.SP_Ins_Egresos(egresosMensuales.ConvertirEntidad(), codigoCaso);

            if (resultado > 0)
            {
                return RedirectToAction("MotivoSolicitud");
            }

            return View(egresosMensuales);
        }

        //-------
        // Paso 6
        //-------
        public ActionResult MotivoSolicitud()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult MotivoSolicitud(Caso_M motivoSolicitud)
        {
            int codigoCaso = Convert.ToInt32(TempData[_CODIGOCASO].ToString());
            TempData.Keep();

            motivoSolicitud.CODCASO25 = codigoCaso;
            var resultado = this.casosSvc.SP_Mod_Caso(motivoSolicitud.ConvertirEntidad());

            if (resultado)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(motivoSolicitud);
        }
    }
}