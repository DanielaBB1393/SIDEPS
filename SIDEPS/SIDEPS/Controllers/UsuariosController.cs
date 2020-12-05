using SIDEPS.Models;
using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult listarUsuarios()

        {
            List<SP_CON_REGUSRO_Result> lstRespuesta = new List<SP_CON_REGUSRO_Result>();
            List<M_Usuarios> lstModeloRespuesta = new List<M_Usuarios>();
            try
            {
                using (ServiciosWCFClient srvUsuario = new ServiciosWCFClient())
                {
                    lstRespuesta = srvUsuario.conUsuario();
                    ViewData["cantones"] = srvUsuario.SP_Con_Cantones().Select(par => new Categoria { Codigo = par.CODCANT03, Descripcion = par.NOMCANT03 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                    ViewData["diaconias"] = srvUsuario.conDiaconias().Select(par => new Categoria { Codigo = par.CODDIAC04, Descripcion = par.NOMDIAC04 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                    ViewData["roles"] = srvUsuario.SP_Con_TipoUsuario().Select(par => new Categoria { Codigo = par.CODUSRO05, Descripcion = par.DESUSRO05 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                }
                foreach (var Usuario in lstRespuesta)
                {
                    M_Usuarios objModeloUsuario = new M_Usuarios();
                    objModeloUsuario.CEDUSRO07 = Usuario.CEDUSRO07;
                    objModeloUsuario.NOMUSRO07 = Usuario.NOMUSRO07;
                    objModeloUsuario.PAPUSRO07 = Usuario.PAPUSRO07;
                    objModeloUsuario.SAPUSRO07 = Usuario.SAPUSRO07;
                    objModeloUsuario.CODCANT03 = Usuario.CODCANT03;
                    objModeloUsuario.CODDIAC04 = Usuario.CODDIAC04;
                    objModeloUsuario.CODUSRO05 = Usuario.CODUSRO05;
                    objModeloUsuario.ESTUSRO07 = Usuario.ESTUSRO07;
                    objModeloUsuario.DIRUSRO07 = Usuario.DIRUSRO07;
                    objModeloUsuario.NACUSRO07 = Usuario.NACUSRO07;
                    objModeloUsuario.CNTUSRO07 = Usuario.CNTUSRO07;
                    objModeloUsuario.FEIUSRO07 = Usuario.FEIUSRO07;
                    objModeloUsuario.FEFUSRO07 = Usuario.FEFUSRO07;
                    objModeloUsuario.FENUSRO07 = Usuario.FENUSRO07;
                    lstModeloRespuesta.Add(objModeloUsuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(lstModeloRespuesta);
        }

        public ActionResult AgregarUsuario()
        {
            M_Usuarios modelo = new M_Usuarios();

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                modelo.Cantones = svc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                modelo.Diaconias = svc.conDiaconias().Select(r => new Categoria { Codigo = r.CODDIAC04, Descripcion = r.NOMDIAC04 }).ToList();
                modelo.Roles = svc.SP_Con_TipoUsuario().Select(r => new Categoria { Codigo = r.CODUSRO05, Descripcion = r.DESUSRO05 }).ToList();
            }
            return View(modelo);
        }

        public ActionResult DetalleUsuario(int id)
        {
            SP_CONXID_REGUSRO_Result objRespuesta = new SP_CONXID_REGUSRO_Result();
            M_Usuarios objUsuario = new M_Usuarios();
            try
            {
                using (ServiciosWCFClient srvUsuarios = new ServiciosWCFClient())
                {
                    objRespuesta = srvUsuarios.conUsuarioXId(id);
                }
                objUsuario.CEDUSRO07 = objRespuesta.CEDUSRO07;
                objUsuario.NOMUSRO07 = objRespuesta.NOMUSRO07;
                objUsuario.PAPUSRO07 = objRespuesta.PAPUSRO07;
                objUsuario.SAPUSRO07 = objRespuesta.SAPUSRO07;
                objUsuario.CODCANT03 = objRespuesta.CODCANT03;
                objUsuario.CODDIAC04 = objRespuesta.CODDIAC04;
                objUsuario.CODUSRO05 = objRespuesta.CODUSRO05;
                objUsuario.ESTUSRO07 = objRespuesta.ESTUSRO07;
                objUsuario.DIRUSRO07 = objRespuesta.DIRUSRO07;
                objUsuario.NACUSRO07 = objRespuesta.NACUSRO07;
                objUsuario.CNTUSRO07 = objRespuesta.CNTUSRO07;
                objUsuario.FEIUSRO07 = objRespuesta.FEIUSRO07;
                objUsuario.FEFUSRO07 = objRespuesta.FEFUSRO07;
                objUsuario.FENUSRO07 = objRespuesta.FENUSRO07;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objUsuario);
        }

        public ActionResult ModificarUsuario(int id)
        {
            SP_CONXID_REGUSRO_Result objRespuesta = new SP_CONXID_REGUSRO_Result();
            M_Usuarios objUsuario = new M_Usuarios();
            try
            {
                using (ServiciosWCFClient srvUsuarios = new ServiciosWCFClient())
                {
                    objRespuesta = srvUsuarios.conUsuarioXId(id);

                    objUsuario.Cantones = srvUsuarios.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                    objUsuario.Diaconias = srvUsuarios.conDiaconias().Select(r => new Categoria { Codigo = r.CODDIAC04, Descripcion = r.NOMDIAC04 }).ToList();
                    objUsuario.Roles = srvUsuarios.SP_Con_TipoUsuario().Select(r => new Categoria { Codigo = r.CODUSRO05, Descripcion = r.DESUSRO05 }).ToList();
                }
                objUsuario.CEDUSRO07 = objRespuesta.CEDUSRO07;
                objUsuario.NOMUSRO07 = objRespuesta.NOMUSRO07;
                objUsuario.PAPUSRO07 = objRespuesta.PAPUSRO07;
                objUsuario.SAPUSRO07 = objRespuesta.SAPUSRO07;
                objUsuario.CODCANT03 = objRespuesta.CODCANT03;
                objUsuario.CODDIAC04 = objRespuesta.CODDIAC04;
                objUsuario.CODUSRO05 = objRespuesta.CODUSRO05;
                objUsuario.ESTUSRO07 = objRespuesta.ESTUSRO07;
                objUsuario.DIRUSRO07 = objRespuesta.DIRUSRO07;
                objUsuario.NACUSRO07 = objRespuesta.NACUSRO07;
                objUsuario.CNTUSRO07 = objRespuesta.CNTUSRO07;
                objUsuario.FEIUSRO07 = objRespuesta.FEIUSRO07;
                objUsuario.FEFUSRO07 = objRespuesta.FEFUSRO07;
                objUsuario.FENUSRO07 = objRespuesta.FENUSRO07;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objUsuario);
        }

        [HttpPost]
        public ActionResult AgregarUsuario(SIDEPS_07REGUSRO objUsuario)
        {
            try
            {
                using (ServiciosWCFClient srvUsuarios = new ServiciosWCFClient())
                {
                    srvUsuarios.insUsuario(objUsuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("listarUsuarios");
        }

        [HttpPost]
        public ActionResult ModificarUsuario(SIDEPS_07REGUSRO objUsuario)
        {
            try
            {
                using (ServiciosWCFClient srvUsuarios = new ServiciosWCFClient())
                {
                    srvUsuarios.modUsuario(objUsuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("listarUsuarios");
        }
    }
}