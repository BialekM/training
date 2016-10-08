using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.OurInstructors;

namespace Toci.Mvcexample.ModelLogic.Handlers
{
    public class InstructorsHandler : Handler
    {
        public override void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel) entity;

            var instructors = new List<Instructor>();
            instructors.Add(
                new Instructor
                {
                    Id = 1,
                    Name = "Bartłomiej Zapart",
                    Specialty = ".NET Developer",
                    SpecialtyDescription = "Senior",
                    Description = "Specjalista zajmujący się...",
                    ImageUrl = "https://scontent-fra3-1.xx.fbcdn.net/v/t1.0-9/44685_102217393170996_2670587_n.jpg?oh=36f636670b9e08d2b759ada776edfc4e&oe=589FFFD0"
                });

            instructors.Add(
                new Instructor
                {
                    Id = 2,
                    Name = "Perła",
                    Specialty = "PHP Developer",
                    SpecialtyDescription = "Middle",
                    Description = "Specjalista zajmujący się...",
                    ImageUrl = "http://www.twojabizuteria.pl/images/kamienie/perla_duza.jpg"
                });

            model.Instructors = new OurInstructorsModel();

            model.Instructors.Instructors = instructors;
        }
    }
}