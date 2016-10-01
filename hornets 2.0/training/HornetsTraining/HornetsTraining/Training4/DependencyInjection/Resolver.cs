using System.Dynamic;
using Autofac;

namespace Toci.HornetsTraining.Training4.DependencyInjection
{
    public static class Resolver
    {
        static Resolver()
        {
            Build();
        }

        private static IContainer Container { get; set; }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        private static void Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TeamLeasingInfo>().As<TeamLeasingInfo>();
            builder.RegisterType<TeamLeasingInfoEnglishTranslation>().As<ITeamLeasingInfoTranslation>();

            Container = builder.Build();
        }
    }
}