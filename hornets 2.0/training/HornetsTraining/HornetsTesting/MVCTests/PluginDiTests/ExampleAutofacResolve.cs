using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Toci.DesignPatterns.PluginDependencyInjection;
using Toci.DesignPatterns.PluginDependencyInjection.DllInjectorForAutofac;

namespace HornetsTesting.MVCTests.PluginDiTests
{
    public static class ExampleAutofacResolve
    {
        private static ContainerBuilder _builder;
        private static IContainer _container;

        static ExampleAutofacResolve()
        {
            RegisterTypes();
        }

        public static T ResolveType<T>()
        {
            return _container.Resolve<T>();
        }

        private static void RegisterTypes()
        {
            _builder = new ContainerBuilder();

            IDiDllInjector dllInjector = new AutofacDllInjector();
            dllInjector.InjectDll("Toci.DevelopersLeasing.Dal");
            dllInjector.RegisterDependencies(_builder);

            _builder.RegisterType<ExampleClass>();

            _container = _builder.Build();

        }
    }
}
