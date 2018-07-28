using Artesanias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Artesanias.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string id="")
        {
            var p = new List<Producto>();
            //logica
            using (var bd = new TiendaEntities())
            {
                p = bd.Producto.Include("ProductoImagen").Where(x => x.Nombre.Contains(id)).ToList();

            }
                return View(p);
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

        public ActionResult Mens()
        {
            ViewBag.Message = "Pagina de artesanias.";

            return View();
        }
        
    }

}