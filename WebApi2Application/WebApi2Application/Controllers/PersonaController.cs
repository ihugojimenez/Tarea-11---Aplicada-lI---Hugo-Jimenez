using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi2Application.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
    }
}