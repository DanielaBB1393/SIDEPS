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
                SIDEPS_07REGUSRO resultado = svc.Login(credenciales.CEDUSRO07, credenciales.CNTUSRO07);
                if (resultado != null)
                {
                    switch (resultado.CODUSRO05.GetValueOrDefault())
                    {
                        case 1:
                            return RedirectToAction("Action", "AdminDiaconiaController");
                        case 2:
                            return RedirectToAction("Action", "AdminDiaconiaController");
                        case 3:
                            return RedirectToAction("Action", "AdminDiaconiaController");
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