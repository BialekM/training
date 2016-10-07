using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training4.HomeWork.MarcinJaniak;

namespace HornetsTesting.Training4.HomeWork.MarcinJaniak
{
    [TestClass]
    public class MarcinJaniakTeamLeasingInfoTests
    {
        [TestMethod]
        public void GetTranslationTest()
        {
            var teamLeasingInfo = new MarcinJaniakTeamLeasingInfoTranslation("pl");

            //_klucz1 doesn't exist
            var result = teamLeasingInfo.GetTranslations(new List<string>() { "_klacz", "_klicz", "_klucz1", "_klucz" });
        }


    }
}