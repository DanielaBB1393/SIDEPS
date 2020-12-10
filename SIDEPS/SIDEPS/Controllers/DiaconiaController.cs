using SIDEPS.Models;
using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class DiaconiaController : Controller
    {
        private const string _CEDULAUSUARIO = "cedulaUsuario";

        public ActionResult listarDiaconias()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            List<SP_CON_REGDIAC_Result> lstRespuesta = new List<SP_CON_REGDIAC_Result>();
            List<Diaconia_M> lstModeloRespuesta = new List<Diaconia_M>();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    lstRespuesta = srvDiac.conDiaconias();
                    ViewData["cantones"] = srvDiac.SP_Con_Cantones().Select(par => new Categoria { Codigo = par.CODCANT03, Descripcion = par.NOMCANT03 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                }
                foreach (var Diaconia in lstRespuesta)
                {
                    Diaconia_M objModeloDiaconia = new Diaconia_M();
                    objModeloDiaconia.CODDIAC04 = Diaconia.CODDIAC04;
                    objModeloDiaconia.NOMDIAC04 = Diaconia.NOMDIAC04;
                    objModeloDiaconia.LUGDIAC04 = Diaconia.LUGDIAC04;
                    objModeloDiaconia.TELDIAC04 = Diaconia.TELDIAC04;
                    objModeloDiaconia.ESTDIAC04 = Diaconia.ESTDIAC04;
                    objModeloDiaconia.CODCANT03 = Diaconia.CODCANT03;
                    lstModeloRespuesta.Add(objModeloDiaconia);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(lstModeloRespuesta);
        }

        public ActionResult AgregarDiaconia()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            var modelo = new Diaconia_M();
            using(var svc = new ServiciosWCFClient())
            {
                modelo.Cantones = svc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
            }

            return View(modelo);
        }

        public ActionResult DetalleDiaconias(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            SP_CONXID_REGDIAC_Result objRespuesta = new SP_CONXID_REGDIAC_Result();
            Diaconia_M objDiaconia = new Diaconia_M();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    objRespuesta = srvDiac.conDiaconiasXId(id);
                }
                objDiaconia.CODDIAC04 = objRespuesta.CODDIAC04;
                objDiaconia.NOMDIAC04 = objRespuesta.NOMDIAC04;
                objDiaconia.LUGDIAC04 = objRespuesta.LUGDIAC04;
                objDiaconia.TELDIAC04 = objRespuesta.TELDIAC04;
                objDiaconia.ESTDIAC04 = objRespuesta.ESTDIAC04;
                objDiaconia.CODCANT03 = objRespuesta.CODCANT03;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objDiaconia);
        }

        public ActionResult EliminarDiaconias(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            SP_CONXID_REGDIAC_Result objRespuesta = new SP_CONXID_REGDIAC_Result();
            Diaconia_M objDiaconia = new Diaconia_M();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    objRespuesta = srvDiac.conDiaconiasXId(id);
                }
                objDiaconia.CODDIAC04 = objRespuesta.CODDIAC04;
                objDiaconia.NOMDIAC04 = objRespuesta.NOMDIAC04;
                objDiaconia.LUGDIAC04 = objRespuesta.LUGDIAC04;
                objDiaconia.TELDIAC04 = objRespuesta.TELDIAC04;
                objDiaconia.ESTDIAC04 = objRespuesta.ESTDIAC04;
                objDiaconia.CODCANT03 = objRespuesta.CODCANT03;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objDiaconia);
        }

        public ActionResult ModificarDiaconias(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            SP_CONXID_REGDIAC_Result objRespuesta = new SP_CONXID_REGDIAC_Result();
            Diaconia_M objDiaconia = new Diaconia_M();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    objRespuesta = srvDiac.conDiaconiasXId(id);
                    objDiaconia.Cantones = srvDiac.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                }
                objDiaconia.CODDIAC04 = objRespuesta.CODDIAC04;
                objDiaconia.NOMDIAC04 = objRespuesta.NOMDIAC04;
                objDiaconia.LUGDIAC04 = objRespuesta.LUGDIAC04;
                objDiaconia.TELDIAC04 = objRespuesta.TELDIAC04;
                objDiaconia.ESTDIAC04 = objRespuesta.ESTDIAC04;
                objDiaconia.CODCANT03 = objRespuesta.CODCANT03;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objDiaconia);
        }

        [HttpPost]
        public ActionResult AgregarDiaconias(SIDEPS_04REGDIAC objDiac)
        {
            TempData.Keep();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    srvDiac.insDiaconia(objDiac);
                 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("listarDiaconias");
        }


        [HttpPost]
        public ActionResult ModificarDiaconias(SIDEPS_04REGDIAC objDiac)
        {
            TempData.Keep();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    srvDiac.modDiaconia(objDiac);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("listarDiaconias");
        }

        public ActionResult HistoricoPorDiaconia()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[_CEDULAUSUARIO].ToString();
            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                // busca casos de la diaconia del usuario
                int codigoDiaconia = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();

                var resultado = svc.SP_Con_HistoricoCasos(codigoDiaconia);
                foreach (var item in resultado)
                {
                    var registro = new HistoricoCaso_M();
                    registro.CODCASO25 = item.CODCASO25;
                    registro.CEDPERS13 = item.CEDPERS13;
                    registro.CEDUSRO07 = item.CEDUSRO07;
                    registro.FEICASO25 = item.FEICASO25;
                    registro.FEFCASO25 = item.FEFCASO25;
                    registro.DESCASO25 = item.DESCASO25;
                    registro.OPICASO25 = item.OPICASO25;
                    registro.ESTCASO25 = item.ESTCASO25;
                    registro.NOMUSRO07 = item.NOMUSRO07;
                    registro.PAPUSRO07 = item.PAPUSRO07;
                    registro.NOMPERS13 = item.NOMPERS13;
                    registro.PAPPERS13 = item.PAPPERS13;
                    modelo.Add(registro);
                }
            }

            return View(modelo);
        }

        public ActionResult DetallesHistorico(int codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            var modelo = new DetallesHistoricoCaso_M();

            using (var svc = new ServiciosWCFClient())
            {
                modelo.DatosPersonales = new DatosPersonales_M(svc.SP_Con_DatosPersonales(codigoCaso));
                modelo.AspectoSalud = new AspectoSalud_M(svc.SP_Con_AspectoSalud(codigoCaso));
                modelo.Vivienda = new Vivienda_M(svc.SP_Con_Vivienda(codigoCaso));
                modelo.GrupoFamiliar = svc.SP_Con_GrupoFamiliar(codigoCaso).Select(familiar => new MiembroFamiliar_M(familiar)).ToList();
                modelo.Egresos = new Egresos_M(svc.SP_Con_Egresos(codigoCaso));
                modelo.OpinionCaso = svc.SP_Con_ObservacionesCaso(codigoCaso);
            }

            return View(modelo);
        }
    }
}