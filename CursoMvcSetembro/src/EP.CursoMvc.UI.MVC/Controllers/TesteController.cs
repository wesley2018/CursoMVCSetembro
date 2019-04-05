using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EP.CursoMvc.UI.MVC.Controllers
{
    [RoutePrefix("")]
    [Route("{action=index}")]
    public class TesteController : Controller
    {
        //celularxiaomi/p/2019/te/motx
        // GET: Teste
        [Route("{produtodesc:maxlength(200)}/p/{produtoid:int}/te/motx")]
        public ActionResult Index(string produtodesc, int produtoid)
        {
            return View();
        }
    }
}