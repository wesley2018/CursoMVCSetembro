using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EP.CursoMvc.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        //[Route("TestedeRoutePrefix")]
        public ActionResult Index()
        {
            return View();
        }
        //[Route("Rosane")]
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
    }
}