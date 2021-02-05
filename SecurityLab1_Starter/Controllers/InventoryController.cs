using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {

            LogingUtil lg = new LogingUtil();
            lg.logToText(filterContext);
            //Redirect or return a view, but not both.
            filterContext.Result = RedirectToAction("Index", "Error");
            // OR
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Error/Index.cshtml"
            };
        }
    }
}