using Toci.EmployeeLeasing.Models.Interfaces.Instructors;

namespace Toci.DevelopersLeasing.Models.Instructors
{
    public class Instructor : IInstructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Specialty { get; set; }
        public string SpecialtyDescription { get; set; }
        public string Description { get; set; }
    }
}