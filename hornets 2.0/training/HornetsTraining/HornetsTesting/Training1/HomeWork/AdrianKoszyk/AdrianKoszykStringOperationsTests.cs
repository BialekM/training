using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training1.HomeWork.AdrianKoszyk;

namespace HornetsTesting.Training1.Homework.AdrianKoszyk
{
   [TestClass]
    public class AdrianKoszykStringOperationsTests
    {
        
       private AdrianKoszykStringOperations AdrKoszStringOperTests= new AdrianKoszykStringOperations();
       
       [TestMethod]
       public void GetNameTest()
       {
           Assert.AreEqual(AdrKoszStringOperTests.GetName(), "Adrian Koszyk");
       }

       [TestMethod]
       public void SubstringTest()
       {
           Assert.AreEqual(AdrKoszStringOperTests.Substring("Adrian", 1, 4), "dria");
           Assert.AreEqual(AdrKoszStringOperTests.Substring("beatka", 1, 3), "eat");
           Assert.AreEqual(AdrKoszStringOperTests.Substring("bartek", 2, 4), "rtek");
       }

       [TestMethod]
       public void PositionInStringTest()
       {
           Assert.AreEqual(AdrKoszStringOperTests.PositionInString("jajko", "k"), 3);
           Assert.AreEqual(AdrKoszStringOperTests.PositionInString("bartek", "k"), 5);
       }

       [TestMethod]
       public void StringReplaceTest()
       {
           Assert.AreEqual(AdrKoszStringOperTests.StringReplace("bartlomiej", "art", "beatka"), "bbeatkalomiej");
           Assert.AreEqual(AdrKoszStringOperTests.StringReplace("programista", "rog", "was"), "pwasramista");
           Assert.AreEqual(AdrKoszStringOperTests.StringReplace("beatka", "e", "s"), "bsatka");
           Assert.AreEqual(AdrKoszStringOperTests.StringReplace("beatka", "atk", "at"), "beata");
          
       }

       

    }
}