using HornetsTraining.Training1.HomeWork.MichalMazur;
using HornetsTraining.Training1.HomeWork.MichałMuzyczka;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.MichalMazur
{
    [TestClass]
    public class MichalMazurListTest
    {
        MichalMazurList<int> listTest = new MichalMazurList<int>();
            [TestMethod]
        public void TestAddAndRemove()
        {
            for(int i=0 ; i <10 ; i++)
                listTest.Add(i);
            listTest.Remove(4);    


        }

         
         
    }
}