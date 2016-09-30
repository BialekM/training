using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training1.HomeWork.AndrzejIwanski;

namespace HornetsTesting.Training1.Homework.AndrzejIwanski
{
    [TestClass]
    public class AndrzejIwanskiListTest
    {
        public AndrzejIwanskiList<int> TestListOfInt = new AndrzejIwanskiList<int>();
        public AndrzejIwanskiList<string> TestListOfString = new AndrzejIwanskiList<string>();
        
        [TestMethod]
        public void AndrzejListTest()
        {
            TestListOfInt.Add(2);
            TestListOfInt.Add(5);
            TestListOfInt.Add(1);

            TestListOfString.Add("dwa");
            TestListOfString.Add("piec");
            TestListOfString.Add("jeden");

            Debug.WriteLine(TestListOfInt.GetItem(0));
            Debug.WriteLine(TestListOfInt.GetItem(1));
            Debug.WriteLine(TestListOfInt.GetItem(2));
            Debug.WriteLine(TestListOfInt.GetItem(3));
            Debug.WriteLine(TestListOfInt.GetItem(4));

            Debug.WriteLine(TestListOfString.GetItem(0));
            Debug.WriteLine(TestListOfString.GetItem(1));
            Debug.WriteLine(TestListOfString.GetItem(2));
            Debug.WriteLine(TestListOfString.GetItem(3));
            Debug.WriteLine(TestListOfString.GetItem(4));
        }
    }
}