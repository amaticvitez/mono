using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using monovitez.DAL;
using monovitez.DAL.FactoryClasses;
using monovitez.DAL.EntityClasses;


namespace monovitez.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            VehicleMakeEntity v = new VehicleMakeEntity();
          

            //var cars  = f.VehicleMake.Field.

            return View(v);
        }
    }
}