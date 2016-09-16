using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.SeeSharpBasics.Test.TablesOperations;
using SeeSharpBasics.DominikRzepnicki;

namespace Toci.SeeSharpBasics.Test.DominikRzepnicki
{
    [TestClass]
    class DominikTablesOperationsTests : TablesOperationsTests
    {
        [TestMethod]
        public override void TestReversing()
        {
            //napisac metode
            var tableOperations = new DominikRzepnickiTablesOperations();
            var parameter = new[] { 1, 2, 3, 4, 5 };
            //var - kompilator wie jaki ma to byc typ; wywolanie metody dla konkretnej tablicy; w tablica bede mial wynik ReverseTable
            var tablica = tableOperations.ReverseTable(parameter);  //5, 4, 3, 2, 1

            //tablica[0] = 5 bo idziemy od konca; parameter[4] = 5; assert klasa statyczna, ktora pomaga nam porownac wartosci - zwracaja True jezeli wartosci sa poprawne
            Assert.AreEqual(tablica[0], parameter[4]);
            Assert.AreEqual(tablica[1], parameter[3]);
            Assert.AreEqual(tablica[2], parameter[2]);



        }
    }
}
