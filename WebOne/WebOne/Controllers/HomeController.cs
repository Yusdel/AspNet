using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOne.Models;


namespace WebOne.Controllers
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

        public ActionResult info()
        {
            Person person = new Person()
            {
                Nome = "Progion",
                Cognome = "Marsetti",
                Age = 25,
                Genre = 'M',
                Bio = "Prodotf sdfade sdasd"
            };

            ViewBag.Message = "myPage";
            DateTime time = DateTime.Now;
            ViewBag.time = time.Hour;

            //or

            if(time.Hour >= 12)
            {
                ViewBag.mes = "Pomeriggio";
            }
            else
            {
                ViewBag.mes = "Mattino";
            }
            return View(person);
        }
    }
}