using System;
using System.Collections.Generic;
using System.IO;
using Autofac;
using Autofac.Integration.Mvc;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.DesignPatterns.PluginDependencyInjection;
using Toci.DesignPatterns.PluginDependencyInjection.DllInjectorForAutofac;
using Toci.Mvcexample.ModelLogic.Handlers;
using Toci.Mvcexample.ModelLogic.Handlers.Enums;
using Toci.Mvcexample.ModelLogic.Interfaces;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models.DBContext;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;
using Toci.Mvcexample.Ntier.Dal.CoursesSearch;

namespace Toci.Mvcexample.DependencyInjection
{
    public static class AutofacResolver
    {
        private static ContainerBuilder _builder;
        private static IContainer _container;

        static AutofacResolver()
        {
            Build();
        }

        public static IContainer GetContainer()
        {
            return _container;
        }

        public static T SimpleResolve<T>()
        {
            return _container.Resolve<T>();
        }

        private static void Build()
        {
            _builder = new ContainerBuilder();
            _builder.RegisterControllers(typeof(MvcApplication).Assembly);

            RegisterTypes();
            _container = _builder.Build();

        }

       
        private static void RegisterTypes()
        {
            //Register Types here

            IDiDllInjector dllInjector = new AutofacDllInjector();

            dllInjector.InjectDll("Toci.DevelopersLeasing.Dal");
            dllInjector.RegisterDependencies(_builder);

            dllInjector.InjectDll("Toci.DevelopersLeasing.Bll");
            dllInjector.RegisterDependencies(_builder);

            _builder.RegisterType<TeamLeasingDBContext>();

            _builder.RegisterType<InstructorsHandler>();
            _builder.RegisterType<RecentProjectsHandler>();
            _builder.RegisterType<CoursesSearchHandler>();

            _builder.RegisterType<CoursesSearchModelStrategyBasic>().
                As<ICoursesSearchModelStrategy>().
                WithParameter("recentModel", null);

            _builder.RegisterType<ModelLogic.ModelLogic>().
                As<IModelLogic>().
                WithParameter("handlers", EHandlers.CoursesSearch | EHandlers.OurInstructors | EHandlers.RecentProjects).
                UsingConstructor(new Type[] {typeof(EHandlers)});

        }
    }
}