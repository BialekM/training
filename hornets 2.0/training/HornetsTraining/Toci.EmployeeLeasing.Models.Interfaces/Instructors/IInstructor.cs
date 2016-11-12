namespace Toci.EmployeeLeasing.Models.Interfaces.Instructors
{
    public interface IInstructor
    {
        int Id { get; set; }
        string Name { get; set; }
        string ImageUrl { get; set; }
        string Specialty { get; set; }
        string SpecialtyDescription { get; set; }
        string Description { get; set; }
    }
}