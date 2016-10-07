using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Mvcexample.Models;

namespace Toci.Mvcexample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(HomeModel model)
        {

            //HomeModel model = new HomeModel { Name = "Toci"};

            return View(model);
        }

        public ActionResult WelcomeToBeSmart()
        {

             
            return View("_WelcomeToBeSmartPartial");
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