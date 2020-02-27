using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistroMVC.Models;

namespace RegistroMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistroTBL obj)
        {
            // Verifica que las validaciones que tenemos en nuestras vistas realmente se esten cumpliendo
            if (ModelState.IsValid)
            {
                // crear una variable para que nos pueda guardar los datos en la base de datos.
                MiRegistroEntities db = new MiRegistroEntities();
                db.RegistroTBLs.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}