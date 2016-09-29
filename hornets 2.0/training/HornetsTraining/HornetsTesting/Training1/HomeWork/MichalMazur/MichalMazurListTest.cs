using Toci.HornetsTraining.Training1.HomeWork.MichalMazur;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.Delegates.MichalMazur
{
    [TestClass]
    public class MichalMazurListTest
    {
        [TestMethod]
        public void Test()
        {
            
            MichalMazurList<int> myList = new MichalMazurList<int>();
            myList.Add(6);
            myList.Add(3);
            myList.Add(2);
            myList.Add(8);

            myList.Remove(6);
            myList.Remove(8);

        }
    }
}