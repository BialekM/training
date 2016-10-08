using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training4.HomeWork;

namespace HornetsTesting.Training4.HomeWork.AdrianPankiewicz
{
    [TestClass]
    public class AdrianPankiewiczTeamLeasingInfoTranslationTests
    {
        [TestMethod]
        public void GetTranslationsTest()
        {
            var teamLeasingInfoTranslation = new TeamLeasingInfoRussianTranslation();
            var teamLeasingTranslations = teamLeasingInfoTranslation.GetTranslations(
                new List<string>{"_klucz", "_klucz2", "_klucz5", "_klucz7", "_klucz3"});

            teamLeasingTranslations.ToList().ForEach( (pair) => Debug.WriteLine(pair.Key + ' ' + pair.Value));
        }
    }
}