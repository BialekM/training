using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;

namespace HornetsTesting.MVCTests.PluginDiTests
{
    public class TestBllImplementation
    {
        private ICoursesSearchBll _coursesSearchBll;
        private IEndDateSearchParams _endDateSearchParams;
        private IInstructorsSearchParams _instructorsSearchParams;
        private ILevelSearchParams _levelSearchParams;
        private IStartDateSearchParams _startDateSearchParams;
        private ITopicsSearchParams _topicsSearchParams;

        public TestBllImplementation(
            ICoursesSearchBll coursesSearchBll, 
            IEndDateSearchParams endDateSearchParams,
            IInstructorsSearchParams instructorsSearchParams,
            ILevelSearchParams levelSearchParams,
            IStartDateSearchParams startDateSearchParams,
            ITopicsSearchParams topicsSearchParams)
        {
            _coursesSearchBll = coursesSearchBll;
            _endDateSearchParams = endDateSearchParams;
            _instructorsSearchParams = instructorsSearchParams;
            _levelSearchParams = levelSearchParams;
            _startDateSearchParams = startDateSearchParams;
            _topicsSearchParams = topicsSearchParams;
        }

        public List<string> GetInstructors()
        {
            return _coursesSearchBll.GetAllowedInstructors(_instructorsSearchParams).ToList();
        }

        public List<DateTime?> GetStartDates()
        {
            return _coursesSearchBll.GetAllowedStartDatas(_startDateSearchParams).ToList();
        }
    }
}
