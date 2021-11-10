using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServiceClient.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormCollection fc)
        {
            wsCupon.wsCupones obwsCupones = new wsCupon.wsCupones();
            string sCupon = fc["txtCupon"];
            string stMensaje = obwsCupones.stConsumirCuponKrispy(sCupon);

            TempData["msg"] = stMensaje;

            return View();
        }


    }
}