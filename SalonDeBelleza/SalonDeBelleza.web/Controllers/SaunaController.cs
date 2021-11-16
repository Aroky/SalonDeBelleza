using SalonDeBelleza.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalondeBelleza.web.Controllers
{
    public class SaunaController : Controller
    {
        // GET: Sauna
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();
            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebSiteUrl"];
            return View(listadeProductos);
        }
    }
}