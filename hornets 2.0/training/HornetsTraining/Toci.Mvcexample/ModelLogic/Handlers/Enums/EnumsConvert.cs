using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Core;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.DependencyInjection;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.NewCoursesSearch;

namespace Toci.Mvcexample.ModelLogic.Handlers.Enums
{
    public class EnumsConvert
    {
        private Dictionary<EHandlers, KeyValuePair<string, Handler>> _enumsToHandlers;

        public EnumsConvert()
        {
            _enumsToHandlers =
                new Dictionary<EHandlers, KeyValuePair<string, Handler>>
                {
                    {
                        EHandlers.CoursesSearch, new KeyValuePair<string, Handler>
                            ("CoursesSearch", AutofacResolver.SimpleResolve<CoursesSearchHandler>())
                    },
                    {
                        EHandlers.OurInstructors, new KeyValuePair<string, Handler>
                            ("OurInstrictors", AutofacResolver.SimpleResolve<InstructorsHandler>())
                    },
                    {
                        EHandlers.RecentProjects, new KeyValuePair<string, Handler>
                            ("RecentProjects", AutofacResolver.SimpleResolve<RecentProjectsHandler>())
                    }
                };
        }

        public Dictionary<string, Handler> ToHandlers(EHandlers handlers)
        {
            var foundHandlers = _enumsToHandlers.Where(handlerInfo => handlers.HasFlag(handlerInfo.Key)).
                Select(handlerInfo => handlerInfo.Value);

            var resolveHandlers = new Dictionary<string, Handler>();

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