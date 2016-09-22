using System;
using HornetsTraining.Training1.HomeWork.BartoszMackiewicz;
using HornetsTraining.Training1.HomeWork.MichałMuzyczka;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.BartoszMackieiwcz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyListTest()
        {
            BartoszMackiewiczList<int> Mylist = new BartoszMackiewiczList<int>();
            Mylist.Add(1);
            Mylist.Add(1);
            Mylist.Add(1);
            Mylist.Add(1);
            Mylist.Add(1);
            Mylist.Add(1);
            Mylist.Add(1);
        }
    }
}
