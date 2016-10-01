using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training4.DependencyInjection;

namespace HornetsTesting.Training4.IoC
{
    [TestClass]
    public class ResolverTest
    {
        [TestMethod]
        public void ResolveTest()
        {
            var teamLeasingInfo = Resolver.Resolve<TeamLeasingInfo>();

            teamLeasingInfo.GetInfo();
        }
    }
}