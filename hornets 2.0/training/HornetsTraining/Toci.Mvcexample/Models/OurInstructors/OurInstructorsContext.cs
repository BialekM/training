using System.Data.Entity;

namespace Toci.Mvcexample.Models.OurInstructors
{
    public class OurInstructorsContext : DbContext
    {
        public DbSet<Instructor> instructors { get; set; }
    }
}