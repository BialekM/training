using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Core;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.DesignPatterns.ChainOfResponsibility.Interfaces;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.OurInstructors;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.RecentProjects;
using Toci.Mvcexample.DependencyInjection;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.NewCoursesSearch;

namespace Toci.Mvcexample.ModelLogic.Handlers.Enums
{
    public class EnumsConvert
    {
        private Dictionary<EHandlers, KeyValuePair<string, IModelHandler>> _enumsToHandlers;

        public EnumsConvert()
        {
            _enumsToHandlers =
                new Dictionary<EHandlers, KeyValuePair<string, IModelHandler>>
                {
                    {
                        EHandlers.CoursesSearch, new KeyValuePair<string, IModelHandler>
                            ("CoursesSearch", AutofacResolver.SimpleResolve<ICoursesSearchHandler>())
                    },
                    {
                        EHandlers.OurInstructors, new KeyValuePair<string, IModelHandler>
                            ("OurInstrictors", AutofacResolver.SimpleResolve<IInstructorsHandler>())
                    },
                    {
                        EHandlers.RecentProjects, new KeyValuePair<string, IModelHandler>
                            ("RecentProjects", AutofacResolver.SimpleResolve<IRecentProjectsHandler>())
                    }
                };
        }

        public Dictionary<string, IModelHandler> ToHandlers(EHandlers handlers)
        {
            var foundHandlers = _enumsToHandlers.Where(handlerInfo => handlers.HasFlag(handlerInfo.Key)).
                Select(handlerInfo => handlerInfo.Value);

            var resolveHandlers = new Dictionary<string, IModelHandler>();

            foreach (var handler in foundHandlers)
            {
                resolveHandlers.Add(handler.Key, handler.Value);
            }

            //var x = AutofacResolver.GetContainer().Resolve<CoursesSearchHandler>
            //(new TypedParameter(typeof(ICoursesSearchModelStrategy),
            //    AutofacResolver.GetContainer().Resolve<CoursesSearchModelStrategyDisplayCourses>(new TypedParameter(typeof(CoursesSearchModel), new CoursesSearchModel()))));

            //x.Handle(new EntireAppModel());

            return resolveHandlers;
        }
    }
}