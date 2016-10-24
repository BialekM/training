using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Mvcexample.ModelLogic.Interfaces;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.DBContext;
using Toci.Mvcexample.Models.OurInstructors;

namespace Toci.Mvcexample.Controllers
{
    public class HomeController : Controller
    {
        private IModelLogic _modelLogic;

        public HomeController(IModelLogic modelLogic)
        {
            _modelLogic = modelLogic;
        }

        public ActionResult Index()
        {

            var model = _modelLogic.GetEntireAppModel();
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