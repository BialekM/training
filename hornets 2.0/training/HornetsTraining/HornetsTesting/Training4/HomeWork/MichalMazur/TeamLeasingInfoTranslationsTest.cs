using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training4.DependencyInjection;
using Toci.HornetsTraining.Training4.HomeWork.MichalMazur;

namespace HornetsTesting.Training4.HomeWork.MichalMazur
{[TestClass]
    public class TeamLeasingInfoTranslationsTest
    {
    [TestMethod]
    public void test()
    {

       
 
       TeamLeasingInfoTranslation test = new MichalMazurTeamLeasingInfoTranslation("pl");
       Dictionary<string,string> translations = test.GetTranslations(new List<string>(){"_klucz","_klucz4"});

    }
    }
}