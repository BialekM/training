using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.OurInstructors;

namespace Toci.Mvcexample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(EntireAppModel model)
        {
            /*
            using (var db = new OurInstructorsContext())
            {
                var instructors = db.instructors;

                return View(instructors);
            }
            */

            ModelLogic.ModelLogic mLogic = new ModelLogic.ModelLogic();

            return View(mLogic.GetEntireAppModel());
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