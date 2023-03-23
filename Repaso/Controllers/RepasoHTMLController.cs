using Repaso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repaso.Controllers
{
    public class RepasoHTMLController : Controller
    {
        // GET: RepasoHTML
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabla()
        {
            return View();
        }

        public ActionResult comboBox()
        {
            return View();
        }

        public ActionResult TablaJS()
        {
            return View();
        }

        public ActionResult ComboBoxJs()
        {
            return View();
        }

        //public List<Persona> listarPersonas() Lista
        public JsonResult  listarPersonas()
        {
            List<Persona> listaPersona = new List<Persona>
            {
                new Persona { idPersona=1, nombre="Eduardo", apellidoPaterno="Cadenas"},
                new Persona { idPersona=2, nombre="Maria", apellidoPaterno="Santos"},
                new Persona { idPersona=3, nombre="Andres", apellidoPaterno="Cadenas"}
            };

            //return listaPersona; retorno de lista
            return Json(listaPersona, JsonRequestBehavior.AllowGet);
        }

        public JsonResult llenaComboPersona()
        {
            List<Persona> listaPersona = new List<Persona>
            {
                new Persona { idPersona=1, nombre="Eduardo"},
                new Persona { idPersona=2, nombre="Maria"},
                new Persona { idPersona=3, nombre="Andres"}
            };
            return Json(listaPersona, JsonRequestBehavior.AllowGet);

        }
    }
}