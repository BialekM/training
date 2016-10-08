using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training4.HomeWork;

namespace HornetsTesting.Training4.HomeWork.WojtekSabat
{
    [TestClass]
    public class TeamLeasingTest
    {
        [TestMethod]
        public void WojtekSabatTeamLeasingTranslationTest_EN()
        {
            var translationInfo = new WojtekSabatTeamLeasingInfoTranslation("en");
            var listOfKeys = new List<string> {"_klucz", "_klucz4", "_klucz7"};
            var expectedResult = new Dictionary<string,string>
            {
                {"_klucz", "start" },
                {"_klucz4", "speaker" },
                {"_klucz7", "apply" },
            };

            Dictionary<string,string> result = translationInfo.GetTranslations(listOfKeys);

            Assert.IsTrue(expectedResult.All(p => result[p.Key] == p.Value));
            Assert.AreEqual(result.Count,expectedResult.Count);
        }
    }
}