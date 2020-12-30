using SIDEPS.Models;
using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class CasosController : Controller
    {
        private readonly ServiciosWCFClient casosSvc = new ServiciosWCFClient();

        // GET: Casos
        public ActionResult Index()
        {
            TempData.Keep();

            return View(new List<Caso_M>());
        }

        //-------
        // Paso 1
        //-------
        public ActionResult DatosPersonales(int? codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();
            ViewData["codigoCaso"] = codigoCaso;

            var modelo = new DatosPersonales_M();

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                if (codigoCaso.HasValue)
                {
                    var entidad = svc.SP_Con_DatosPersonales(codigoCaso.Value);
                    modelo = new DatosPersonales_M(entidad);
                }
                // Carga las listas que se usan en los Dropdowns
                modelo.Religiones = svc.SP_Con_Religiones().Select(r => new Categoria { Codigo = r.CODRELG11, Descripcion = r.DESRELG11 }).ToList();
                modelo.Cantones = svc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                modelo.EstadosCiviles = svc.SP_Con_EstadosCivil().Select(r => new Categoria { Codigo = r.CODESTC06, Descripcion = r.DESESTC06 }).ToList();
                modelo.Escolaridades = svc.SP_Con_NivelEducativo().Select(r => new Categoria { Codigo = r.CODNEDU09, Descripcion = r.DESNEDU09 }).ToList();
                modelo.CategoriaSolicitante = svc.SP_Con_CategoriaSolicitud().Select(r => new Categoria { Codigo = r.CODSOLI10, Descripcion = r.DESSOLI10 }).ToList();
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult DatosPersonales(int? codigoCasoModificar, DatosPersonales_M persona)
        {
            //obtiene de la memoria el usuario que esta loguiado
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var guardoPersona = this.casosSvc.SP_InsMod_Persona(persona.ConvertirEntidad(), codigoCasoModificar);
            if (guardoPersona)
            {
          
                var caso = new Caso_M
                {
                    CEDPERS13 = persona.CEDPERS13,
                    CEDUSRO07 = cedulaUsuario,
                };
                
                int codigoCaso;
                if (codigoCasoModificar != null)
                {
                    // no inserta solo asigna el codigo del caso que se esta modificando
                    codigoCaso = codigoCasoModificar.Value;
                }
                else
                {
                    // inserta el caso en base de datos porque es un caso nuevo
                    codigoCaso = this.casosSvc.SP_Ins_Caso(caso.ConvertirEntidad());
                }
                if (codigoCaso > 0)
                {
                    // el caso se inserto
                    TempData[Combos._CEDULAPERSONA] = persona.CEDPERS13;
                    TempData[Combos._CODIGOCASO] = codigoCaso;

                    return RedirectToAction("AspectoSalud", new { codigoCaso = codigoCasoModificar });
                }
            }
            else
            {
                ModelState.AddModelError("CEDPERS13", "El usuario ya existe");
                // no pudo guardar la persona
                using (ServiciosWCFClient svc = new ServiciosWCFClient())
                {
                    persona.Religiones = svc.SP_Con_Religiones().Select(r => new Categoria { Codigo = r.CODRELG11, Descripcion = r.DESRELG11 }).ToList();
                    persona.Cantones = svc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                    persona.EstadosCiviles = svc.SP_Con_EstadosCivil().Select(r => new Categoria { Codigo = r.CODESTC06, Descripcion = r.DESESTC06 }).ToList();
                    persona.Escolaridades = svc.SP_Con_NivelEducativo().Select(r => new Categoria { Codigo = r.CODNEDU09, Descripcion = r.DESNEDU09 }).ToList();
                    persona.CategoriaSolicitante = svc.SP_Con_CategoriaSolicitud().Select(r => new Categoria { Codigo = r.CODSOLI10, Descripcion = r.DESSOLI10 }).ToList();
                }
            }
            return View(persona);
        }

        //-------
        // Paso 2
        //-------
        public ActionResult AspectoSalud(int? codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            var modelo = new AspectoSalud_M();
            using (var svc = new ServiciosWCFClient())
            {
                if (codigoCaso.HasValue)
                {
                    var entidad = svc.SP_Con_AspectoSalud(codigoCaso.Value);
                    modelo = new AspectoSalud_M(entidad);
                }
                modelo.Enfermedades = svc.SP_Con_Enfermedades().Select(enf => new Categoria { Codigo = enf.CODENFR15, Descripcion = enf.DESENFR15 }).ToList();
                modelo.TiposSeguro = svc.SP_Con_Seguros().Select(seg => new Categoria { Codigo = seg.CODSEGU14, Descripcion = seg.DESSEGU14 }).ToList();
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult AspectoSalud(AspectoSalud_M aspecto)
        {
            aspecto.CEDPERS13 = TempData[Combos._CEDULAPERSONA].ToString();
            int codigoCaso = Convert.ToInt32(TempData[Combos._CODIGOCASO].ToString());
            TempData.Keep();

            var resultado = this.casosSvc.SP_InsMod_AspectoSalud(aspecto.ConvertirEntidad(), codigoCaso);
            if (resultado > 0)
            {
                return RedirectToAction("Vivienda", new { codigoCaso });
            }
            else
            {
                using(var svc = new ServiciosWCFClient())
                {
                    aspecto.Enfermedades = svc.SP_Con_Enfermedades().Select(enf => new Categoria { Codigo = enf.CODENFR15, Descripcion = enf.DESENFR15 }).ToList();
                    aspecto.TiposSeguro = svc.SP_Con_Seguros().Select(seg => new Categoria { Codigo = seg.CODSEGU14, Descripcion = seg.DESSEGU14 }).ToList();
                }
                return View(aspecto);
            }
        }

        //-------
        // Paso 3
        //-------
        public ActionResult Vivienda(int? codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            var modelo = new Vivienda_M();
            using (var svc = new ServiciosWCFClient())
            {
                if (codigoCaso.HasValue)
                {
                    var entidad = svc.SP_Con_Vivienda(codigoCaso.Value);
                    modelo = new Vivienda_M(entidad);
                }
                modelo.Tipos = svc.SP_Con_TipoVivienda().Select(tip => new Categoria { Codigo = tip.CODTIPV18, Descripcion = tip.DESTIPV18 }).ToList();
                modelo.Estados = svc.SP_Con_EstadoVivienda().Select(est => new Categoria { Codigo = est.CODESTV19, Descripcion = est.DESESTV19 }).ToList();
                modelo.Materiales = svc.SP_Con_Materiales().Select(mat => new Categoria { Codigo = mat.CODMATE17, Descripcion = mat.DESMATE17 }).ToList();
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult Vivienda(Vivienda_M vivienda)
        {
            int codigoCaso = Convert.ToInt32(TempData[Combos._CODIGOCASO].ToString());
            TempData.Keep();

            var resultado = this.casosSvc.SP_Ins_Vivienda(vivienda.ConvertirEntidad(), codigoCaso);

            if (resultado > 0)
            {
                TempData[Combos._CODIGOVIVIENDA] = resultado;
                return RedirectToAction("GrupoFamiliar", new { codigoCaso });
            }

            return View(vivienda);
        }

        //-------
        // Paso 4
        //-------
        public ActionResult GrupoFamiliar(int? codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaSolicitante = TempData[Combos._CEDULAPERSONA].ToString();
            TempData.Keep();
            ViewData["codigoCaso"] = codigoCaso;

            List<MiembroFamiliar_M> grupoFamiliar;
            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                grupoFamiliar = svc.ConGrupoFamiliarXId(cedulaSolicitante).Select(familiar => new MiembroFamiliar_M(familiar)).ToList();
                ViewData["estadoCivil"] = svc.SP_Con_EstadosCivil().Select(ec => new Categoria { Codigo = ec.CODESTC06, Descripcion = ec.DESESTC06 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                ViewData["escolaridad"] = svc.SP_Con_NivelEducativo().Select(edu => new Categoria { Codigo = edu.CODNEDU09, Descripcion = edu.DESNEDU09 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                ViewData["organizaciones"] = svc.SP_Con_Organizaciones().Select(org => new Categoria { Codigo = org.CODORGS21, Descripcion = org.DESORGS21 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                ViewData["enfermedades"] = svc.SP_Con_Enfermedades().Select(enf => new Categoria { Codigo = enf.CODENFR15, Descripcion = enf.DESENFR15 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
                ViewData["parentescos"] = svc.SP_Con_Parentescos().Select(par => new Categoria { Codigo = par.CODPARE12, Descripcion = par.DESPARE12 }).ToDictionary(i => i.Codigo, i => i.Descripcion);
            }

            return View(grupoFamiliar);
        }

        public ActionResult AgregarFamiliar()
        {
            TempData.Keep();

            var modelo = new MiembroFamiliar_M();
            using (var svc = new ServiciosWCFClient())
            {
                modelo.EstadosCiviles = svc.SP_Con_EstadosCivil().Select(ec => new Categoria { Codigo = ec.CODESTC06, Descripcion = ec.DESESTC06 }).ToList();
                modelo.Escolaridad = svc.SP_Con_NivelEducativo().Select(edu => new Categoria { Codigo = edu.CODNEDU09, Descripcion = edu.DESNEDU09 }).ToList();
                modelo.Organizaciones = svc.SP_Con_Organizaciones().Select(org => new Categoria { Codigo = org.CODORGS21, Descripcion = org.DESORGS21 }).ToList();
                modelo.Enfermedades = svc.SP_Con_Enfermedades().Select(enf => new Categoria { Codigo = enf.CODENFR15, Descripcion = enf.DESENFR15 }).ToList();
                modelo.Parentescos = svc.SP_Con_Parentescos().Select(par => new Categoria { Codigo = par.CODPARE12, Descripcion = par.DESPARE12 }).ToList();
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult AgregarFamiliar(MiembroFamiliar_M modelo)
        {
            var cedulaSolicitante = TempData[Combos._CEDULAPERSONA].ToString();
            TempData.Keep();

            var guardoFamiliar = this.casosSvc.SP_Ins_MiembroFamiliar(modelo.ConvertirEntidad(), cedulaSolicitante);
            if (!guardoFamiliar)
            {
                using (var svc = new ServiciosWCFClient())
                {
                    modelo.EstadosCiviles = svc.SP_Con_EstadosCivil().Select(ec => new Categoria { Codigo = ec.CODESTC06, Descripcion = ec.DESESTC06 }).ToList();
                    modelo.Escolaridad = svc.SP_Con_NivelEducativo().Select(edu => new Categoria { Codigo = edu.CODNEDU09, Descripcion = edu.DESNEDU09 }).ToList();
                    modelo.Organizaciones = svc.SP_Con_Organizaciones().Select(org => new Categoria { Codigo = org.CODORGS21, Descripcion = org.DESORGS21 }).ToList();
                    modelo.Enfermedades = svc.SP_Con_Enfermedades().Select(enf => new Categoria { Codigo = enf.CODENFR15, Descripcion = enf.DESENFR15 }).ToList();
                    modelo.Parentescos = svc.SP_Con_Parentescos().Select(par => new Categoria { Codigo = par.CODPARE12, Descripcion = par.DESPARE12 }).ToList();
                }

                ModelState.AddModelError("CEDFAML22", "El familiar ya existe");
                return View(modelo);
            }
            return RedirectToAction("GrupoFamiliar");
        }

        public ActionResult DetallesFamiliar(string id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            MiembroFamiliar_M modelo;

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                var familiar = svc.SP_Con_MiembroFamiliarXid(id);
                modelo = new MiembroFamiliar_M(familiar);
            }

            return View(modelo);
        }

        public ActionResult EliminarFamiliar(string id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            MiembroFamiliar_M modelo;

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                var familiar = svc.SP_Con_MiembroFamiliarXid(id);
                modelo = new MiembroFamiliar_M(familiar);
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult EliminarFamiliar(MiembroFamiliar_M familiar)
        {
            TempData.Keep();

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                svc.SP_Del_MiembroFamiliarXid(familiar.CEDFAML22);
            }

            return RedirectToAction("GrupoFamiliar");
        }

        public ActionResult ModificarFamiliar(string id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            MiembroFamiliar_M modelo;

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                var familiar = svc.SP_Con_MiembroFamiliarXid(id);
                modelo = new MiembroFamiliar_M(familiar);
                modelo.EstadosCiviles = svc.SP_Con_EstadosCivil().Select(ec => new Categoria { Codigo = ec.CODESTC06, Descripcion = ec.DESESTC06 }).ToList();
                modelo.Escolaridad = svc.SP_Con_NivelEducativo().Select(edu => new Categoria { Codigo = edu.CODNEDU09, Descripcion = edu.DESNEDU09 }).ToList();
                modelo.Organizaciones = svc.SP_Con_Organizaciones().Select(org => new Categoria { Codigo = org.CODORGS21, Descripcion = org.DESORGS21 }).ToList();
                modelo.Enfermedades = svc.SP_Con_Enfermedades().Select(enf => new Categoria { Codigo = enf.CODENFR15, Descripcion = enf.DESENFR15 }).ToList();
                modelo.Parentescos = svc.SP_Con_Parentescos().Select(par => new Categoria { Codigo = par.CODPARE12, Descripcion = par.DESPARE12 }).ToList();
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult ModificarFamiliar(MiembroFamiliar_M familiar)
        {
            TempData.Keep();

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                svc.SP_Mod_MiembroFamiliar(familiar.ConvertirEntidad());
            }

            return RedirectToAction("GrupoFamiliar");
        }

        //-------
        // Paso 5
        //-------
        public ActionResult Egresos(int? codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            Egresos_M modelo = new Egresos_M();
            using(var svc = new ServiciosWCFClient())
            {
                if (codigoCaso.HasValue)
                {
                    var entidad = svc.SP_Con_Egresos(codigoCaso.Value);
                    modelo = new Egresos_M(entidad);
                }
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult Egresos(Egresos_M egresosMensuales)
        {
            int codigoCaso = Convert.ToInt32(TempData[Combos._CODIGOCASO].ToString());
            TempData.Keep();

            var resultado = this.casosSvc.SP_Ins_Egresos(egresosMensuales.ConvertirEntidad(), codigoCaso);

            if (resultado > 0)
            {
                return RedirectToAction("MotivoSolicitud", new { codigoCaso });
            }

            return View(egresosMensuales);
        }

        //-------
        // Paso 6
        //-------
        public ActionResult MotivoSolicitud(int? codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            Caso_M modelo = new Caso_M();
            using(var svc = new ServiciosWCFClient())
            {
                if (codigoCaso.HasValue)
                {
                    var entidad = svc.ConCaso(codigoCaso.Value);
                    modelo = new Caso_M(entidad);
                }
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult MotivoSolicitud(Caso_M motivoSolicitud)
        {
            int codigoCaso = Convert.ToInt32(TempData[Combos._CODIGOCASO].ToString());
            TempData.Keep();

            motivoSolicitud.CODCASO25 = codigoCaso;
            if (motivoSolicitud.ESTCASO25.Equals(Combos.CASO_INCOMPLETO))
            {
                motivoSolicitud.ESTCASO25 = Combos.CASO_PENDIENTE;
            }

            var resultado = this.casosSvc.SP_Mod_Caso(motivoSolicitud.ConvertirEntidad());

            if (resultado)
            {
                return RedirectToAction("MenuCasos");
            }

            return View(motivoSolicitud);
        }

        //---------------
        //Historiales
        //---------------
        public ActionResult HistoricoDeCasos(int? diaconiaSeleccionada)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                if (diaconiaSeleccionada == null)
                {
                    // diaconía a la que el usuario pertenece
                    diaconiaSeleccionada = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04;
                }

                //List<Categoria> diaconiasCombo = new List<Categoria>();

                //List<SP_CON_REGDIAC_Result> diaconias = svc.conDiaconias();
                //foreach (var diaconia in diaconias)
                //{
                //    diaconiasCombo.Add(new Categoria { Codigo = diaconia.CODDIAC04, Descripcion = diaconia.NOMDIAC04 });

                //}

                var diaconias = svc.conDiaconias().Select(diaconia => new Categoria { Codigo = diaconia.CODDIAC04, Descripcion = diaconia.NOMDIAC04 }).ToList();
                ViewData["diaconias"] = diaconias;

                var resultado = svc.SP_Con_HistoricoCasos(diaconiaSeleccionada.GetValueOrDefault());
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
            TempData.Keep();

            var modelo = new DetallesHistoricoCaso_M();

            using (var svc = new ServiciosWCFClient())
            {
                modelo.DatosPersonales = new DatosPersonales_M(svc.SP_Con_DatosPersonales(codigoCaso));
                modelo.AspectoSalud = new AspectoSalud_M(svc.SP_Con_AspectoSalud(codigoCaso));
                modelo.Vivienda = new Vivienda_M(svc.SP_Con_Vivienda(codigoCaso));
                modelo.GrupoFamiliar = svc.SP_Con_GrupoFamiliar(codigoCaso).Select(familiar => new MiembroFamiliar_M(familiar)).ToList();
                modelo.Egresos = new Egresos_M(svc.SP_Con_Egresos(codigoCaso));
                modelo.OpinionCaso = svc.SP_Con_ObservacionesCaso(codigoCaso);
                modelo.AyudasAprobadas = svc.SP_Con_AyudasXcaso(codigoCaso);
            }

            return View(modelo);
        }

        public ActionResult MenuCasos()
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
                    ViewData["menuPrevioMetodo"] = "MenuParroquial";
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

            return View();
        }

        public ActionResult ValidarCaso()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                int diaconia = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();

                var resultado = svc.SP_Con_HistoricoCasos(diaconia).Where(caso => caso.ESTCASO25.Equals(Combos.CASO_PENDIENTE));
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

        public ActionResult CasoIncompleto()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                int diaconia = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();

                var resultado = svc.SP_Con_HistoricoCasos(diaconia).Where(caso => caso.ESTCASO25.Equals(Combos.CASO_INCOMPLETO));
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

        public ActionResult EliminarCaso(int codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            Caso_M modelo = new Caso_M();

            using(var casosSvc = new ServiciosWCFClient())
            {
                modelo = new Caso_M(casosSvc.ConCaso(codigoCaso));
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult EliminarCaso(Caso_M caso)
        {
            TempData.Keep();

            using (var svc = new ServiciosWCFClient())
            {
                svc.EliminarCaso(caso.CODCASO25);
            }

            return RedirectToAction("CasoIncompleto");
        }

        public ActionResult ValidarCasoMantenimiento()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            string tipoUsuario = TempData[Combos._TIPOUSUARIO].ToString();

            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                int diaconia = 0;
                if (tipoUsuario.Equals(Combos.ADMIN_DIACONAL, StringComparison.OrdinalIgnoreCase))
                {
                    diaconia = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();
                }

                var resultado = svc.SP_Con_HistoricoCasos(diaconia).Where(caso => !caso.ESTCASO25.Equals(Combos.CASO_PENDIENTE));
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

        public ActionResult ValidarCasoAprobados()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                int diaconia = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();

                var resultado = svc.SP_Con_HistoricoCasos(diaconia).Where(caso => caso.ESTCASO25.Equals(Combos.CASO_APROBADO));
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

        public ActionResult ModificarAyudas(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            var caso = this.casosSvc.ConCaso(id);
            var modelo = new AprobarCaso_M()
            {
                CodigoCaso = caso.CODCASO25
            };

            var ayudas = this.casosSvc.SP_Con_CategoriasAyudas();
            var ayudasAsignadas = this.casosSvc.SP_Con_AyudasXcaso(id);

            modelo.Ayudas = ayudas.Select(ayuda => new TipoAyuda_M
            {
                //si la ayudas esta asignada la muestra seleccionada en el checkbox
                Aprobado = ayudasAsignadas.Any(aya => aya.CODAYUD26 == ayuda.CODAYUD26),
                Codigo = ayuda.CODAYUD26,
                Descripcion = ayuda.DESAYUD26
            }).ToList();

            return View(modelo);
        }

        [HttpPost]
        public ActionResult ModificarAyudas(AprobarCaso_M modelo)
        {
            TempData.Keep();

            var caso = new Caso_M
            {
                FEICASO25 = DateTime.Now,
                ESTCASO25 = Combos.CASO_APROBADO,
                CODCASO25 = modelo.CodigoCaso,
            };

            this.casosSvc.SP_Mod_Caso(caso.ConvertirEntidad());

            List<SIDEPS_27TIPAYUD> ayudasAprobadas = new List<SIDEPS_27TIPAYUD>();

            foreach (var ayuda in modelo.Ayudas.Where(ayuda => ayuda.Aprobado))
            {
                var ayudaBD = new SIDEPS_27TIPAYUD
                {
                    CODCASO25 = modelo.CodigoCaso,
                    CODAYUD26 = ayuda.Codigo
                };

                ayudasAprobadas.Add(ayudaBD);
            }

            this.casosSvc.SP_InsMod_AyudasXCaso(ayudasAprobadas, modelo.CodigoCaso);

            return RedirectToAction("MenuCasos");
        }

        public ActionResult ModificarCaso(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            SP_CON_CASOXID_Result resultado;

            using (var svc = new ServiciosWCFClient())
            {
                resultado = svc.ConCaso(id);
            }

            var caso = new Caso_M(resultado);
            return View(caso);
        }

        [HttpPost]
        public ActionResult ModificarCaso(Caso_M caso)
        {
            TempData.Keep();

            using (var svc = new ServiciosWCFClient())
            {
                svc.SP_Mod_Caso(caso.ConvertirEntidad());
            }

            return RedirectToAction("MenuCasos");
        }


        public ActionResult ModificarEstadoCaso(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            SP_CON_CASOXID_Result resultado;

            using (var svc = new ServiciosWCFClient())
            {
                resultado = svc.ConCaso(id);
            }

            var caso = new Caso_M(resultado);
            return View(caso);
        }

        [HttpPost]
        public ActionResult ModificarEstadoCaso(Caso_M caso)
        {
            TempData.Keep();

            using (var svc = new ServiciosWCFClient())
            {
                svc.SP_Mod_Caso(caso.ConvertirEntidad());
            }

            return RedirectToAction("MenuCasos");
        }


        public ActionResult ValidarCasoDetalles(int codigoCaso)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

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

        public ActionResult AprobarCaso(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            var caso = this.casosSvc.ConCaso(id);
            var modelo = new AprobarCaso_M()
            {
                CodigoCaso = caso.CODCASO25
            };

            var ayudas = this.casosSvc.SP_Con_CategoriasAyudas();

            modelo.Ayudas = ayudas.Select(ayuda => new TipoAyuda_M
            {
                Codigo = ayuda.CODAYUD26,
                Descripcion = ayuda.DESAYUD26
            }).ToList();

            return View(modelo);
        }

        [HttpPost]
        public ActionResult AprobarCaso(AprobarCaso_M model)
        {
            TempData.Keep();

            var caso = new Caso_M
            {
                FEICASO25 = DateTime.Now,
                ESTCASO25 = Combos.CASO_APROBADO,
                CODCASO25 = model.CodigoCaso,
            };

            this.casosSvc.SP_Mod_Caso(caso.ConvertirEntidad());

            List<SIDEPS_27TIPAYUD> ayudasAprobadas = new List<SIDEPS_27TIPAYUD>();

            foreach (var ayuda in model.Ayudas.Where(ayuda => ayuda.Aprobado))
            {
                var ayudaBD = new SIDEPS_27TIPAYUD
                {
                    CODCASO25 = model.CodigoCaso,
                    CODAYUD26 = ayuda.Codigo
                };

                ayudasAprobadas.Add(ayudaBD);
            }

            this.casosSvc.SP_InsMod_AyudasXCaso(ayudasAprobadas, model.CodigoCaso);

            return RedirectToAction("MenuCasos");
        }

        public ActionResult RechazarCaso(int id)
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            TempData.Keep();

            var resultado = this.casosSvc.ConCaso(id);
            var modelo = new Caso_M(resultado);

            return View(modelo);
        }

        [HttpPost]
        public ActionResult RechazarCaso(Caso_M caso)
        {
            TempData.Keep();

            caso.ESTCASO25 = Combos.CASO_RECHAZADO;
            caso.FEFCASO25 = DateTime.Now;

            this.casosSvc.SP_Mod_Caso(caso.ConvertirEntidad());

            return RedirectToAction("MenuCasos");
        }
    }
}