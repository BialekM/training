using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training1.HomeWork.KonradGalazka;

namespace HornetsTesting.Training1.Homework.KonradGalazka
{
    [TestClass]
    public class KonradGalazkaListTest
    {
        [TestMethod]
        public void Test()
        {
            KonradGalazkaMyList<int> list = new KonradGalazkaMyList<int>();

            list.Add(8);
            list.Add(42);
        }
    }
}