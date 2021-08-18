using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Door2Door3.Controllers
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
        public ActionResult Cadastro()
        {
            ViewBag.Message = "Cadastrar Usuario.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Logar Usuario.";

            return View();
        }
    }
}