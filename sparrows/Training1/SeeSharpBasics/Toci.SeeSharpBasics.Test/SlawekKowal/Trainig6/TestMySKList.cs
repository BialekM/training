using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.SlawekKowal.Training6;
using SeeSharpBasics.Training5.Chess;

namespace Toci.SeeSharpBasics.Test.SlawekKowal.Trainig6
{
    [TestClass]
    public class TestMySKList
    {
        [TestMethod]
        public void TestMe()
        {
            SlawekKMyList<int> lista = new SlawekKMyList<int>();
            for (int x = 0; x <= 10; x++) lista.Add(x);
            var xx = lista.GetLenght();
            lista.RemoveItem(3);
            xx = lista.GetIndex(5);
            Debug.WriteLine(xx);
            xx = lista.GetLenght();
            xx = lista.SumAll();
            Debug.WriteLine(xx);

            foreach (var item in lista) Debug.WriteLine(item.ToString());
            ChessField[] chField = new ChessField[10];

            for (int x = 0; x < 10; x++) chField[x] = new ChessField { X = x, Y = 0, Colour = x % 2 == 0 };
            SlawekKMyList<ChessField> lista1 = new SlawekKMyList<ChessField>();
            foreach (var item in chField) lista1.Add(item);
            foreach (var item in lista1) Debug.WriteLine(item.ToString());
        }
    }
}