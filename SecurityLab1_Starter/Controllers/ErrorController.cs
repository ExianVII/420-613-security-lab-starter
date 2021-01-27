using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class ErrorController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        // GET: Error
        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult ServerError()
        {
            ViewBag.CurrentUrl = Request.QueryString["aspxerrorpath"];
            return View();
        }
    }
}