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
                    TempData[Combos._CEDULAUSUARIO] = credenciales.CEDUSRO07;
                    TempData[Combos._TIPOUSUARIO] = resultado;

                    switch (resultado)
                    {
                        case Combos.ADMIN_PARROQUIAL:
                            return RedirectToAction("MenuParroquial", "AdminParroquial");

                        case Combos.ADMIN_DIACONAL:
                            return RedirectToAction("AdminDiaconal", "AdminDiaconal");

                        case Combos.COLABORADOR:
                            return RedirectToAction("MenuColaborador", "MenuColaborador");

                        default:
                            //Agrega mensaje de error en cedula
                            ModelState.AddModelError("CEDUSRO07", "Ocurrió un error con el tipo de usuario");
                            break;
                    }
                }
                else
                {
                    //Agrega mensaje de error en cedula
                    ModelState.AddModelError("CEDUSRO07", "Datos Incorrectos");
                }
            }
            return View(credenciales);
        }

        public ActionResult MenuAdministradorDiaconia()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

        public ActionResult MenuColaboradorDiaconia()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

        public ActionResult MenuAdministradorParroquial()
        {
            if (!TempData.ContainsKey(Combos._CEDULAUSUARIO))
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

        public ActionResult Salir()
        {
            TempData.Clear();

            return RedirectToAction("Login");
        }
    }
}