using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;
using Toci.Mvcexample.Models.DBContext;

namespace Toci.DevelopersLeasing.Dal.CoursesSearch
{
    public class ProgrammingCoursesSearchDal : ICoursesSearchDal
    {
        private TeamLeasingDBContext _teamLeasingDb;

        public ProgrammingCoursesSearchDal(TeamLeasingDBContext teamLeasingDb)
        {
            _teamLeasingDb = teamLeasingDb;
        }

        public IQueryable<ICourseModel> GetCourses(ICoursesSearchParams searchParams)
        {
            IQueryable<ICourseModel> result = _teamLeasingDb.course.
                Where(course =>
                    (searchParams.Topic == null || course.topic == searchParams.Topic) &&
                    (searchParams.Start == null || course.start_date == searchParams.Start) &&
                    (searchParams.End == null || course.end_date == searchParams.End) &&
                    (searchParams.Level == null || course.level == searchParams.Level) &&
                    (searchParams.Instructor == null ||
                     course.technologypromotor.account.lastName + " " + course.technologypromotor.account.firstName == searchParams.Instructor) &&
                    (searchParams.Technologies == null)).
                Select(course => 
                    new ProgrammingCourseModel
                    {
                        CourseName = course.topic,
                        Instructor = course.technologypromotor.account.firstName + " " + course.technologypromotor.account.lastName,
                        Start = course.start_date,
                        End = course.end_date,
                        Level = course.level,
                        Agenda = course.agenda
                    });

            return result;
        }
    }
}
