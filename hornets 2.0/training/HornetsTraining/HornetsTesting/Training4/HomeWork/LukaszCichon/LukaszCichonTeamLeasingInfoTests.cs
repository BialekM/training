using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training4.HomeWork.LukaszCichon;

namespace HornetsTesting.Training4.HomeWork.LukaszCichon
{
    [TestClass]
    public class LukaszCichonTeamLeasingInfoTests
    {
        [TestMethod]
        public void translationTest()
        {
            List<string> keysList= new List<string>()
            {
                "_klucz", "costam1","costam2", "_klucz3", "_klucz5", "ahsjasfjkhaskjf", "_klucz8"
            }; 
            
            var teamLeasingInfo = new LukaszCichonTeamLeasingInfoTranslation("en"); 

            //_klucz1 doesn't exist
            var result = teamLeasingInfo.GetTranslations(keysList);
        }
        
    }
}