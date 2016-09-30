using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training1.HomeWork;
using Toci.HornetsTraining.Training1.HomeWork.MichałMuzyczka;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HornetsTesting.Training1.HomeWorkOwnTests
{
    [TestClass]
    public class MichalMuzyczkaTests
    {
        [TestMethod]
        public void SubstringTest()
        {
            var results = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                results[i] = true;
            }

            var target = getTarget();
            var s1 = target.Substring("Higashi", 2, 2);
            if (s1 != "ga")
            {
                results[0] = false;
            }

            var s2 = target.Substring("Higashi", 3, 10);
            if (s2 != "ashi")
            {
                results[1] = false;
            }

            var s3 = target.Substring("Higashi", 3, 0); 
            if (s3 != string.Empty)
            {
                results[2] = false;
            }

            if (results.Any(x => x == false))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            // Arrange
            var target = getTarget();
            var results = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                results[i] = true;
            }

            // Act
            var r1 = target.StringReplace("higAShi", "AS", "MAMI"); // higMAMIhi
            if (r1 != "higMAMIhi")
                results[0] = true;

            var r2 = target.StringReplace("KaTSUkaTSUki", "tsu", "YOKATTA!"); // KaYOKATTAkaYOKATTAki
            if (r1 != "KaYOKATTAkaYOKATTAki")
                results[1] = true;

            var r3 = target.StringReplace("maMImumemoMI", "mi", "X"); // maXmumemoX
            if (r1 != "maXmumemoX")
                results[2] = true;

            var r4 = target.StringReplace("Wakewake", "X", "Y"); // Wakewake
            if (r1 != "Wakewake")
                results[3] = true;

            // Assert
            var info = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                if (!results[i])
                {
                    info += i.ToString() + "is wrong /r/n";
                }
            }

            if(results.Any(x => x == false))
                Assert.Fail(info);
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            // Arrange
            var target = getTarget();

            // Act
            var s1 = target.PositionInString("Higashi", "ga"); // 2
            var s2 = target.PositionInString("Higashi", "X"); // -1

            // Assert
            Assert.AreEqual(2, s1);
            Assert.AreEqual(-1, s2);
        }


        public StringOperations getTarget()
        {
            return  new MichalStringOperations();
        }
    }
}
