using System.Collections.Generic;
using Autofac;
using Autofac.Integration.Mvc;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Handlers;
using Toci.Mvcexample.ModelLogic.Interfaces;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;
using Toci.Mvcexample.Ntier.Dal.CoursesSearch;

namespace Toci.Mvcexample.DependencyInjection
{
    public static class AutofacResolver
    {
        private static IContainer _container;
        static AutofacResolver()
        {
            Build();
        }

        public static IContainer GetContainer()
        {
            return _container;
        }

        private static void Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            RegisterTypes(builder);
            _container = builder.Build();

        }

        

        

        private static void RegisterTypes(ContainerBuilder builder)
        {
            //Register Types here
            builder.Register(c => new ModelLogic.ModelLogic(
                new Dictionary<string, Handler>
                {
                    { "OurInstructors", new InstructorsHandler() },
                    { "CoursesSearch", new CoursesSearchHandler(new CoursesSearchModelStrategyBasic(), new CoursesSearchLogic(new CoursesSearchDal())) },
                    { "RecentProjects", new RecentProjectsHandler()}
                })).As<IModelLogic>();

        }
    }
}