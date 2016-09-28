using Toci.HornetsTraining.Training1.Overdloading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Overriding
{
    [TestClass]
    public class OverridingTest
    {
        [TestMethod]
        public void Test()
        {
            OverloadingExampleChild child = new OverloadingExampleChild();

            child.Whatever();
            child.Whatever(2.33);

            OverloadingExample child2 = new OverloadingExampleChild();

            child2.Whatever();
            child2.Whatever(2.33);
        }
    }
}