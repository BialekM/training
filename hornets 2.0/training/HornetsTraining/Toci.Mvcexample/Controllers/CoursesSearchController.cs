using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Handlers;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch.CourseDisplay;
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
        public ActionResult CoursesSearch()
        {
            var myModel = new CoursesSearchModel();

            myModel.Discipline.Items = CoursesSearchModel.ToSelectList(
                _courses.tblCourses.Select((courses) => courses.Discipline).Distinct());

            myModel.Duration.Items = CoursesSearchModel.ToSelectList(
                _courses.tblCourses.Select((courses) => courses.Duration.ToString()).Distinct(), " Months");

            myModel.CourseLevel.Items = CoursesSearchModel.ToSelectList(
                _courses.tblCourses.Select((courses) => courses.CourseLevel).Distinct());

            myModel.Location.Items = CoursesSearchModel.ToSelectList(
                _courses.tblCourses.Select((courses) => courses.Location).Distinct());


            return View(myModel);
        }

        [HttpPost]
        public ActionResult CoursesSearch(CoursesSearchModel model)
        {
            CoursesDisplayModel coursesModel = new CoursesDisplayModel { Courses = new List<CourseDisplay> { new CourseDisplay() { Name = "c#", Keywords = new List<string> { "cokolwiek" }} } };

            //selecting courses that match user's input
            /*var foundCourses = _courses.tblCourses.Where(
                c => (model.Discipline.Value == null || c.Discipline == model.Discipline.Value) &&
                     (model.Duration.Value == null || c.Duration == model.Duration.Value) &&
                     (model.CourseLevel.Value == null || c.CourseLevel == model.CourseLevel.Value) &&
                     (model.Location.Value == null || c.Location == model.Location.Value));

            foreach (var course in foundCourses)
            {
                //selecting keywords for every course (just for test)
                var keywords = _courses.tblCourse_KeyWord
                    .Join(_courses.tblCourses,
                        c_kw => c_kw.Course_ID,
                        c => c.ID,
                        (c_kw, c) => new { CourseKW = c_kw, Course = c })
                    .Where(x => x.Course.ID == course.ID)
                    .Join(_courses.tblKeywords,
                        x => x.CourseKW.KeyWord_ID,
                        k => k.ID,
                        (x, k) => new { CoursesKeyWord = k.Keyword });

                var keywordsList = new List<string>();
                foreach (var keyword in keywords)
                {
                    keywordsList.Add(keyword.CoursesKeyWord);
                }

                coursesModel.Courses.Add(
                    new CourseDisplay
                    {
                        Name = course.Name,
                        Keywords = keywordsList
                    });

            }*/



            return CoursesDisplay(coursesModel);
        }

        [AllowAnonymous]
        public ActionResult CoursesDisplay(CoursesDisplayModel model)
        {
            ModelLogic.ModelLogic mLogic = new ModelLogic.ModelLogic(
                new Dictionary<string, Handler>
                {
                    { "OurInstructors", new InstructorsHandler() },
                    { "CoursesSearc", new CoursesSearchHandler(new CoursesSearchModelStrategyBasic(), new CoursesSearchLogic(new CoursesSearchDal())) }
                }); // model logic w konstruktorze lista handlerow
            var entireModel = mLogic.GetEntireAppModel();
            //handler!!
            entireModel.CoursesResult = model;

            return View("~/Views/Home/Index.cshtml", entireModel);
        }

        [HttpPost]
        public ActionResult CoursesDisplay()
        {
            return RedirectToAction("CoursesSearch");
        }


    }
}