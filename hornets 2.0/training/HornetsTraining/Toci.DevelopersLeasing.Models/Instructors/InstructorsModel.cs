using System.Collections.Generic;
using System.Linq;
using Toci.EmployeeLeasing.Models.Interfaces.Instructors;

namespace Toci.DevelopersLeasing.Models.Instructors
{
    public class InstructorsModel : IInstructorsModel
    {
        public InstructorsModel(IEnumerable<IInstructor> instructors)
        {
            Instructors = instructors.ToList();
            Instructors.Clear();
        }

        public List<IInstructor> Instructors { get; set; }
    }
}