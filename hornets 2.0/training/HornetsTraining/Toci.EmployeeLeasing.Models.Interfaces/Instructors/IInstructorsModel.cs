using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Models.Interfaces.Instructors
{
    public interface IInstructorsModel
    {
        List<IInstructor> Instructors { get; set; }
    }
}