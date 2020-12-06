using SIDEPS.Models;
using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class HomeController : Controller
    {

        private const string _CEDULAUSUARIO = "cedulaUsuario";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(M_Usuarios credenciales)
        {
            using (ServiciosWCFClient svc = new ServiciosWCFClient())
            {
                string resultado = svc.Login(credenciales.CEDUSRO07, credenciales.CNTUSRO07);
                if (resultado != null)
                {
                    TempData[_CEDULAUSUARIO] = credenciales.CEDUSRO07;

                    switch (resultado)
                    {
                        case "ADMIN PARROQUIAL":
                            //return RedirectToAction("Action", "AdminParroquialController");
                        case "ADMIN DIACONAL":
                            //return RedirectToAction("Action", "AdminDiaconiaController");
                        case "COLABORADOR":
                            //return RedirectToAction("Action", "ColaboradorController");
                            return RedirectToAction("Index");
                        default:
                            //Agrega mensaje de error en cedula
                            ModelState.AddModelError("CEDUSRO07", "Ocurrió un error con el tipo de usuario");
                            break;
                    }
                }
                else
                {
                    //Agrega mensaje de error en cedula
                    ModelState.AddModelError("CEDUSRO07", "Usuario no registrado");
                }
            }
            return View(credenciales);
        }

        public ActionResult MenuAdministradorDiaconia()
        {
            return View();
        }

        public ActionResult MenuColaboradorDiaconia()
        {
            return View();
        }

        public ActionResult MenuAdministradorParroquial()
        {
            return View();
        }
    }
}