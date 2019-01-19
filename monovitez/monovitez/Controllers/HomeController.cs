using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using monovitezEnt;
using monovitezEnt.FactoryClasses;

namespace monovitez.Controllers
{
    public class HomeController : Controller
    {

        QueryFactory f = new QueryFactory();

        public ActionResult Index()
        {
            //var cars  = f.VehicleMake.Field.

            return View();
        }
    }
}