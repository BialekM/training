using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch.CourseDisplay;

//Prawdopodobnie metody powinny byc zawarte w Controllerze odpowiedzialnym za wyswietlanie konkretnej zakladki

//Jaki jest wlasciwy sposob zmiany widokow wraz z przekazywaniem odpowiednich modeli ?

//Jak rozsadnie wykorzystac wzorzez Dependancy injection w MVC ?

//Jak powinno się dołączać baze danych do projektu, i jaki 'connection string' powinno sie podawac,
//by dzialalo uniwersalnie ?

//To play with Database need to create it from script (Models/Courses/ScriptForDatabase) and edit connection string (Web.config)

namespace Toci.Mvcexample.Controllers
{
    public class CoursesSearchController : Controller
    {
        private readonly CoursesSearchEntities _courses;

        public CoursesSearchController()
        {
            _courses = new CoursesSearchEntities();
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
            CoursesDisplayModel coursesModel = new CoursesDisplayModel { Courses = new List<CourseDisplay>() };

            //selecting courses that match user's input
            var foundCourses = _courses.tblCourses.Where(
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

            }

            return CoursesDisplay(coursesModel);
        }

        [AllowAnonymous]
        public ActionResult CoursesDisplay(CoursesDisplayModel model)
        {

            return View("~/Views/CoursesSearch/CoursesDisplay.cshtml", model);
        }

        [HttpPost]
        public ActionResult CoursesDisplay()
        {
            return RedirectToAction("CoursesSearch");
        }


    }
}