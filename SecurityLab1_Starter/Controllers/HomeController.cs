using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //500 error
        public ActionResult GenError()
        {
            return new HttpStatusCodeResult(500);
            throw new Exception();
            throw new DivideByZeroException(); //DivisionByZero is something that works with a different library and I don't know how to use.
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
    }
}