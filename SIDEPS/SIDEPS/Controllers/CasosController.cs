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
        public ActionResult DatosPersonales()
        {
            TempData.Keep();

            var modelo = new DatosPersonales_M();

            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                modelo.Religiones = svc.SP_Con_Religiones().Select(r => new Categoria { Codigo = r.CODRELG11, Descripcion = r.DESRELG11 }).ToList();
                modelo.Cantones = svc.SP_Con_Cantones().Select(r => new Categoria { Codigo = r.CODCANT03, Descripcion = r.NOMCANT03 }).ToList();
                modelo.EstadosCiviles = svc.SP_Con_EstadosCivil().Select(r => new Categoria { Codigo = r.CODESTC06, Descripcion = r.DESESTC06 }).ToList();
                modelo.Escolaridades = svc.SP_Con_NivelEducativo().Select(r => new Categoria { Codigo = r.CODNEDU09, Descripcion = r.DESNEDU09 }).ToList();
                modelo.CategoriaSolicitante = svc.SP_Con_CategoriaSolicitud().Select(r => new Categoria { Codigo = r.CODSOLI10, Descripcion = r.DESSOLI10 }).ToList();
            }

            return View(modelo);
        }

        [HttpPost]
        public ActionResult DatosPersonales(DatosPersonales_M persona)
        {
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var resultadoP = this.casosSvc.SP_Ins_Persona(persona.ConvertirEntidad());
            if (resultadoP)
            {
                var caso = new Caso_M
                {
                    CEDPERS13 = persona.CEDPERS13,
                    CEDUSRO07 = cedulaUsuario,
                };

                var resultadoC = this.casosSvc.SP_Ins_Caso(caso.ConvertirEntidad());
                if (resultadoC > 0)
                {
                    TempData[Combos._CEDULAPERSONA] = persona.CEDPERS13;
                    TempData[Combos._CODIGOCASO] = resultadoC;

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

            var modelo = new AspectoSalud_M();
            using (var svc = new ServiciosWCFClient())
            {
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

            var modelo = new Vivienda_M();
            using (var svc = new ServiciosWCFClient())
            {
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
                return RedirectToAction("GrupoFamiliar");
            }

            return View(vivienda);
        }

        //-------
        // Paso 4
        //-------
        public ActionResult GrupoFamiliar()
        {
            string cedulaSolicitante = TempData[Combos._CEDULAPERSONA].ToString();
            TempData.Keep();

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

            var resultado = this.casosSvc.SP_Ins_MiembroFamiliar(modelo.ConvertirEntidad(), cedulaSolicitante);
            if (!resultado)
            {
                ViewData["mensaje"] = "Ocurrió un error agregando a " + modelo.NOMFAML22;
                return View(modelo);
            }
            return RedirectToAction("GrupoFamiliar");
        }

        public ActionResult DetallesFamiliar(string id)
        {
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
        public ActionResult Egresos()
        {
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult Egresos(Egresos_M egresosMensuales)
        {
            int codigoCaso = Convert.ToInt32(TempData[Combos._CODIGOCASO].ToString());
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
            int codigoCaso = Convert.ToInt32(TempData[Combos._CODIGOCASO].ToString());
            TempData.Keep();

            motivoSolicitud.CODCASO25 = codigoCaso;
            motivoSolicitud.ESTCASO25 = Combos.CASO_PENDIENTE;

            var resultado = this.casosSvc.SP_Mod_Caso(motivoSolicitud.ConvertirEntidad());

            if (resultado)
            {
                return RedirectToAction("MenuCasos");
            }

            return View(motivoSolicitud);
        }

        //---------------
        // Mantenimientos
        //---------------
        public ActionResult HistoricoDeCasos(int? diaconiaSeleccionada)
        {
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                if(diaconiaSeleccionada == null)
                {
                    // diaconia a la que el usuario pertenece
                    diaconiaSeleccionada = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04;
                }

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

        public ActionResult MenuCasos()
        {
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

        public ActionResult ValidarCasoMantenimiento()
        {
            string cedulaUsuario = TempData[Combos._CEDULAUSUARIO].ToString();
            TempData.Keep();

            var modelo = new List<HistoricoCaso_M>();

            using (var svc = new ServiciosWCFClient())
            {
                int diaconia = svc.conUsuarioXCedula(cedulaUsuario).CODDIAC04.GetValueOrDefault();

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
        public ActionResult ModificarCaso(int id)
        {
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
            using (var svc = new ServiciosWCFClient())
            {
                svc.SP_Mod_Caso(caso.ConvertirEntidad());
            }

            return RedirectToAction("ValidarCaso");
        }

        public ActionResult ValidarCasoDetalles(int codigoCaso)
        {
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
            
            foreach(var ayuda in model.Ayudas.Where( ayuda => ayuda.Aprobado))
            {
                var ayudaBD = new SIDEPS_27TIPAYUD
                {
                    CODCASO25 = model.CodigoCaso,
                    CODAYUD26 = ayuda.Codigo
                };

                ayudasAprobadas.Add(ayudaBD);
            }

            this.casosSvc.SP_Ins_AyudasXCaso(ayudasAprobadas);

            return RedirectToAction("MenuCasos");
        }

        public ActionResult RechazarCaso(int id)
        {
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