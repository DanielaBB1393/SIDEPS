using SIDEPS.Models;
using SIDEPS.WCFPersonas;
using System.Web.Mvc;

namespace SIDEPS.Controllers
{
    public class PersonasController : Controller
    {
        private readonly IPersonasSvc personasSvc = new PersonasSvcClient();

        // GET: Personas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insertar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insertar(Persona_M persona)
        {
            var resultado = this.personasSvc.SP_Ins_RegistroPersona(persona.ConvertirEntidadP());
            if (resultado)
            {
                return Redirect("~/");
            }
            else
            {
                return View(persona);
            }
        }
    }
}