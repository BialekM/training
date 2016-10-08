using Autofac;
using Autofac.Integration.Mvc;
using Toci.Mvcexample.ModelLogic.Interfaces;

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
            builder.RegisterType<ModelLogic.ModelLogic>().As<IModelLogic>();
        }
    }
}