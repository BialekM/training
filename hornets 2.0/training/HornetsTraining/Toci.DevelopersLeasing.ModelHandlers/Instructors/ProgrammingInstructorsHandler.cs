using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.OurInstructors;
using Toci.EmployeeLeasing.Models.Interfaces.Instructors;
using Toci.Mvcexample.Models;
using Toci.DevelopersLeasing.Models.Instructors;

namespace Toci.DevelopersLeasing.ModelHandlers.Instructors
{
    public class ProgrammingInstructorsHandler : IInstructorsHandler
    {
        private IInstructorsModel _instructorsModel;

        public ProgrammingInstructorsHandler(IInstructorsModel model)
        {
            _instructorsModel = model;
        }

        public void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            _instructorsModel.Instructors.Add(
                new Instructor
                {
                    Id = 1,
                    Name = "Bartłomiej Zapart",
                    Specialty = ".NET Developer",
                    SpecialtyDescription = "Senior",
                    Description = "Specjalista zajmujący się...",
                    ImageUrl = "https://scontent-fra3-1.xx.fbcdn.net/v/t1.0-9/44685_102217393170996_2670587_n.jpg?oh=36f636670b9e08d2b759ada776edfc4e&oe=589FFFD0"
                });

            _instructorsModel.Instructors.Add(
                new Instructor
                {
                    Id = 2,
                    Name = "Perła",
                    Specialty = "PHP Developer",
                    SpecialtyDescription = "Middle",
                    Description = "Specjalista zajmujący się...",
                    ImageUrl = "http://www.twojabizuteria.pl/images/kamienie/perla_duza.jpg"
                });

            model.Instructors = _instructorsModel;

        }
    }
}