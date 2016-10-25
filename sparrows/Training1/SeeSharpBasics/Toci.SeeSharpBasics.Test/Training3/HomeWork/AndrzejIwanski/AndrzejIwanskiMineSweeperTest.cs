using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Homework.AndrzejIwanski;

namespace Toci.SeeSharpBasics.Test.Training3.HomeWork.AndrzejIwanski
{
    [TestClass]
    public class AndrzejIwanskiMineSweeperTest
    {
        [TestMethod]
        public void Test()
        {
            AndrzejIwanskiMineSweeper aimMineSweeper = new AndrzejIwanskiMineSweeper();

            var asd = aimMineSweeper.BombsCount(15,2,10);

            aimMineSweeper.Draw(asd);
        }
         
    }
}