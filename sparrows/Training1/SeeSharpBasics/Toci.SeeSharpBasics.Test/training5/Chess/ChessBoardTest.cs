using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.MagdaSkalik.Homework3;
using SeeSharpBasics.Training5;
using SeeSharpBasics.Training5.Chess;

namespace Toci.SeeSharpBasics.Test.training5.Chess
{
    [TestClass]
    public class ChessBoardTest
    {
        [TestMethod]
        public void Test()
        {
            MagdaBankResolver res = new MagdaBankResolver();

            res.GetBankName("1610");

            //ChessField chessField = new ChessField();

            //StaticClass st = new StaticClass();

            Figure f = new Rook();

            //f.Move()

            StaticClass.Move();

            //chessField.
        }
    }
}