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
        public ActionResult ListarUsuarios()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }

            string tipoUsuario = TempData[Combos._TIPOUSUARIO].ToString();

            switch (tipoUsuario)
            {
                case Combos.COLABORADOR:
                    ViewData["menuPrevioMetodo"] = "MenuColaborador";
                    ViewData["menuPrevioControlador"] = "MenuColaborador";
                    break;

                case Combos.ADMIN_PARROQUIAL:
                    ViewData["menuPrevioMetodo"] = "MenuMantenimiento";
                    ViewData["menuPrevioControlador"] = "AdminParroquial";
                    break;

                case Combos.ADMIN_DIACONAL:
                    ViewData["menuPrevioMetodo"] = "AdminDiaconal";
                    ViewData["menuPrevioControlador"] = "AdminDiaconal";
                    break;

                default:
                    ViewData["menuPrevioMetodo"] = "Salir";
                    ViewData["menuPrevioControlador"] = "Home";
                    break;
            }

            TempData.Keep();

            List<SP_CON_REGUSRO_Result> lstRespuesta = new List<SP_CON_REGUSRO_Result>();
            List<M_Usuarios> lstModeloRespuesta = new List<M_Usuarios>();
            try
            {
                using (ServiciosWCFClient srvUsuario = new ServiciosWCFClient())
                {
                    // si el usuario es admin diaconal muestra colaboradores
                    if (tipoUsuario.Equals(Combos.ADMIN_DIACONAL))
                    {
                        // Admin Diaconal solo puede ver colaboradores
                        lstRespuesta = srvUsuario.conUsuario().Where(usuario => tipoUsuario.Equals(Combos.ADMIN_DIACONAL, StringComparison.OrdinalIgnoreCase) && usuario.CODUSRO05 == 3).ToList();
                    }

                    // si el usuario es admin parroquial muestra todos los tipos de usuarios
                    else
                    {
                        // Admin Parroquial
                        lstRespuesta = srvUsuario.conUsuario().ToList();
                    }

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
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string tipoUsuario = TempData[Combos._TIPOUSUARIO].ToString();
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();

            TempData.Keep();

            M_Usuarios modelo = new M_Usuarios();

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                modelo.Cantones = svc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                modelo.Diaconias = svc.conDiaconias().Select(r => new Categoria { Codigo = r.CODDIAC04, Descripcion = r.NOMDIAC04 }).ToList();
                int diaconiaUsuario = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();

                // defino cuales codigos de roles puede agregar un usuario
                List<int> codigosRoles;

                switch (tipoUsuario)
                {
                    case Combos.ADMIN_PARROQUIAL:
                        codigosRoles = new List<int> { 1, 2, 3 };
                        break;

                    case Combos.ADMIN_DIACONAL:
                        codigosRoles = new List<int> { 3 };
                        modelo.Diaconias = modelo.Diaconias.Where(d => d.Codigo == diaconiaUsuario).ToList();
                        break;

                    case Combos.COLABORADOR:
                    default:
                        codigosRoles = new List<int>();
                        modelo.Diaconias = new List<Categoria>();
                        modelo.Cantones = new List<Categoria>();
                        break;
                }

                modelo.Roles = svc.SP_Con_TipoUsuario()
                .Where(r => codigosRoles.Contains(r.CODUSRO05))
                .Select(r => new Categoria { Codigo = r.CODUSRO05, Descripcion = r.DESUSRO05 }).ToList();
            }
            return View(modelo);
        }

        public ActionResult DetalleUsuario(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }

            TempData.Keep();

            SP_CONXID_REGUSRO_Result objRespuesta = new SP_CONXID_REGUSRO_Result();
            M_Usuarios objUsuario = new M_Usuarios();
            try
            {
                using (ServiciosWCFClient srvUsuarios = new ServiciosWCFClient())
                {
                    objRespuesta = srvUsuarios.conUsuarioXId(id);
                    ViewData["cantones"] = srvUsuarios.SP_Con_Cantones().Select(par => new Categoria { Codigo = par.CODCANT03, Descripcion = par.NOMCANT03 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                    ViewData["diaconias"] = srvUsuarios.conDiaconias().Select(par => new Categoria { Codigo = par.CODDIAC04, Descripcion = par.NOMDIAC04 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                    ViewData["roles"] = srvUsuarios.SP_Con_TipoUsuario().Select(par => new Categoria { Codigo = par.CODUSRO05, Descripcion = par.DESUSRO05 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
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
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            SP_CONXID_REGUSRO_Result objRespuesta = new SP_CONXID_REGUSRO_Result();
            M_Usuarios objUsuario = new M_Usuarios();
            try
            {
                string tipoUsuario = TempData[Combos._TIPOUSUARIO].ToString();

                using (ServiciosWCFClient srvUsuarios = new ServiciosWCFClient())
                {
                    objRespuesta = srvUsuarios.conUsuarioXId(id);

                    objUsuario.Cantones = srvUsuarios.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                    objUsuario.Diaconias = srvUsuarios.conDiaconias().Select(r => new Categoria { Codigo = r.CODDIAC04, Descripcion = r.NOMDIAC04 }).ToList();
                    objUsuario.Roles = srvUsuarios.SP_Con_TipoUsuario().Select(r => new Categoria { Codigo = r.CODUSRO05, Descripcion = r.DESUSRO05 }).ToList();
                    int diaconiaUsuario = srvUsuarios.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();
                    // defino cuales codigos de roles puede agregar un usuario
                    List<int> codigosRoles;

                    switch (tipoUsuario)
                    {
                        case Combos.ADMIN_PARROQUIAL:
                            codigosRoles = new List<int> { 1, 2, 3 };
                            break;

                        case Combos.ADMIN_DIACONAL:
                            codigosRoles = new List<int> { 3 };
                            objUsuario.Diaconias = objUsuario.Diaconias.Where(d => d.Codigo == diaconiaUsuario).ToList();
                            break;

                        case Combos.COLABORADOR:
                        default:
                            codigosRoles = new List<int>();
                            objUsuario.Diaconias = new List<Categoria>();
                            objUsuario.Cantones = new List<Categoria>();
                            break;
                    }

                    objUsuario.Roles = srvUsuarios.SP_Con_TipoUsuario()
                    .Where(r => codigosRoles.Contains(r.CODUSRO05))
                    .Select(r => new Categoria { Codigo = r.CODUSRO05, Descripcion = r.DESUSRO05 }).ToList();
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
        public ActionResult AgregarUsuario(M_Usuarios objUsuario)
        {
            string tipoUsuario = TempData[Combos._TIPOUSUARIO].ToString();
            TempData.Keep();

            try
            {
                bool agregado = false;
                using (ServiciosWCFClient srvUsuarios = new ServiciosWCFClient())
                {
                    agregado = srvUsuarios.insUsuario(objUsuario.ConvertirEntidad());
                    if (!agregado)
                    {
                        ModelState.AddModelError("CEDUSRO07", "El usuario ya existe");
                        objUsuario.Cantones = srvUsuarios.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                        objUsuario.Diaconias = srvUsuarios.conDiaconias().Select(r => new Categoria { Codigo = r.CODDIAC04, Descripcion = r.NOMDIAC04 }).ToList();

                        // defino cuales codigos de roles puede agregar un usuario
                        List<int> codigosRoles;

                        switch (tipoUsuario)
                        {
                            case Combos.ADMIN_PARROQUIAL:
                                codigosRoles = new List<int> { 1, 2, 3 };
                                break;

                            case Combos.ADMIN_DIACONAL:
                                codigosRoles = new List<int> { 3 };
                                break;

                            case Combos.COLABORADOR:
                            default:
                                codigosRoles = new List<int>();
                                break;
                        }

                        objUsuario.Roles = srvUsuarios.SP_Con_TipoUsuario()
                        .Where(r => codigosRoles.Contains(r.CODUSRO05))
                        .Select(r => new Categoria { Codigo = r.CODUSRO05, Descripcion = r.DESUSRO05 }).ToList();

                        return View(objUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("ListarUsuarios");
        }

        [HttpPost]
        public ActionResult ModificarUsuario(SIDEPS_07REGUSRO objUsuario)
        {
            TempData.Keep();

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
            return RedirectToAction("ListarUsuarios");
        }
    }
}