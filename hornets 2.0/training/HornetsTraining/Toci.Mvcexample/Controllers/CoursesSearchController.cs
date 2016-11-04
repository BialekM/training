using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Handlers;
using Toci.Mvcexample.ModelLogic.Handlers.Enums;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.NewCoursesSearch.CourseDisplay;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;
using Toci.Mvcexample.Ntier.Bll.Interfaces;
using Toci.Mvcexample.Ntier.Dal.CoursesSearch;

namespace Toci.Mvcexample.Controllers
{
    public class CoursesSearchController : Controller
    {
        private readonly CoursesSearchEntities _courses;
        protected ICoursesSearchLogic CoursesSearchLogic;

        public CoursesSearchController(ICoursesSearchLogic coursesSearchLogic)
        {
            _courses = new CoursesSearchEntities();

            CoursesSearchLogic = coursesSearchLogic;
        }
        // GET: Test
        //public ActionResult CoursesSearch()
        //{
        //    var myModel = new CoursesSearchModel();

        //    myModel.Discipline.Items = CoursesSearchModel.ToSelectList(
        //        _courses.tblCourses.Select((courses) => courses.Discipline).Distinct());

        //    myModel.Duration.Items = CoursesSearchModel.ToSelectList(
        //        _courses.tblCourses.Select((courses) => courses.Duration.ToString()).Distinct(), " Months");

        //    myModel.CourseLevel.Items = CoursesSearchModel.ToSelectList(
        //        _courses.tblCourses.Select((courses) => courses.CourseLevel).Distinct());

        //    myModel.Location.Items = CoursesSearchModel.ToSelectList(
        //        _courses.tblCourses.Select((courses) => courses.Location).Distinct());


        //    return View(myModel);
        //}

        [HttpPost]
        public ActionResult CoursesSearch(CoursesSearchModel model)
        {
            CoursesDisplayModel coursesModel = new CoursesDisplayModel { Courses = new List<CourseDisplay> { new CourseDisplay() { Name = "c#", Keywords = new List<string> { "cokolwiek" }} } };



            return CoursesDisplay(coursesModel);
        }

        [AllowAnonymous]
        public ActionResult CoursesDisplay(CoursesDisplayModel model)
        {
            ModelLogic.ModelLogic mLogic = new ModelLogic.ModelLogic(EHandlers.OurInstructors); // model logic w konstruktorze lista handlerow
            var entireModel = mLogic.GetEntireAppModel();
            //handler!!
            //entireModel.CoursesResult = model;

            return View("~/Views/Home/Index.cshtml", entireModel);
        }

        [HttpPost]
        public ActionResult CoursesDisplay()
        {
            return RedirectToAction("CoursesSearch");
        }


    }
}