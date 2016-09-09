using HornetsTraining.Training1.HomeWork.KrzysztofPater;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.KrzysztofPater
{
    [TestClass]
    public class KrzysztofPaterMyListTest
    {
        [TestMethod]
        public void AddTest()
        {
            KrzysztofPaterMyList<int> itemsList = new KrzysztofPaterMyList<int>();

            for (int i = 0; i < 200; i++)
            {
                itemsList.Add(i);
            }
        }

    }
}