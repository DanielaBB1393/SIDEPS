using SIDEPS.Models;
using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace mvcSIDEPSWeb.Controllers
{
    public class DiaconiaController : Controller
    {
        public ActionResult listarDiaconias()
        {
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
            var modelo = new Diaconia_M();
            using(var svc = new ServiciosWCFClient())
            {
                modelo.Cantones = svc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
            }

            return View(modelo);
        }

        public ActionResult DetalleDiaconias(int id)
        {
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

        public ActionResult AgregarDiaconiasC(SIDEPS_04REGDIAC objDiac)
        {
            List<SP_CON_REGDIAC_Result> lstRespuesta = new List<SP_CON_REGDIAC_Result>();
            List<Diaconia_M> lstModeloRespuesta = new List<Diaconia_M>();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    if (srvDiac.insDiaconia(objDiac))
                    {
                        lstRespuesta = srvDiac.conDiaconias();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarDiaconias", lstModeloRespuesta);
        }

        public ActionResult EliminarDiaconiasC(SIDEPS_04REGDIAC objDiac)
        {
            List<SP_CON_REGDIAC_Result> lstRespuesta = new List<SP_CON_REGDIAC_Result>();
            List<Diaconia_M> lstModeloRespuesta = new List<Diaconia_M>();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    if (srvDiac.delDiaconia(objDiac))
                    {
                        lstRespuesta = srvDiac.conDiaconias();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarDiaconias", lstModeloRespuesta);
        }

        public ActionResult ModificarDiaconiasC(SIDEPS_04REGDIAC objDiac)
        {
            List<SP_CON_REGDIAC_Result> lstRespuesta = new List<SP_CON_REGDIAC_Result>();
            List<Diaconia_M> lstModeloRespuesta = new List<Diaconia_M>();
            try
            {
                using (ServiciosWCFClient srvDiac = new ServiciosWCFClient())
                {
                    if (srvDiac.modDiaconia(objDiac))
                    {
                        lstRespuesta = srvDiac.conDiaconias();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarDiaconias", lstModeloRespuesta);
        }

        [HttpPost]
        public ActionResult Acciones(string submitButton, Diaconia_M pDiac)
        {
            try
            {
                SIDEPS_04REGDIAC objDiac = new SIDEPS_04REGDIAC();
                objDiac.CODDIAC04 = pDiac.CODDIAC04;
                objDiac.NOMDIAC04 = pDiac.NOMDIAC04;
                objDiac.LUGDIAC04 = pDiac.LUGDIAC04;
                objDiac.TELDIAC04 = pDiac.TELDIAC04;
                objDiac.ESTDIAC04 = pDiac.ESTDIAC04;
                objDiac.CODCANT03 = pDiac.CODCANT03;

                switch (submitButton)
                {
                    case "Agregar":
                        return AgregarDiaconiasC(objDiac);

                    case "Actualizar":
                        return ModificarDiaconiasC(objDiac);

                    case "Eliminar":
                        return EliminarDiaconiasC(objDiac);

                    default:
                        return RedirectToAction("listarDiaconias");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}