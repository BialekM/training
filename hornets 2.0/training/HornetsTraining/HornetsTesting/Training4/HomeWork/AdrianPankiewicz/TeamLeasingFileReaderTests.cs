using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training4.HomeWork;

namespace HornetsTesting.Training4.HomeWork.AdrianPankiewicz
{
    [TestClass]
    public class TeamLeasingFileReaderTests
    {
        [TestMethod]
        public void ReadDictionaryTest()
        {
            Dictionary<string, string> keyValuesPairs =
                TeamLeasingFileReader.ReadDictionary("TeamLeasingInfoTranslation.ru.txt");

            var list = keyValuesPairs.ToList();

            list.ForEach( (pair) => Debug.WriteLine(pair.Key + ' ' + pair.Value));
        }
    }
}