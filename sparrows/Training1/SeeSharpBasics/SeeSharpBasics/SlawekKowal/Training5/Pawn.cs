using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class Pawn : Figure
    {
        public override bool Move(int srcX, int srcY, int destX, int destY, ChessBoard chess)
        {
            chess.Chess[destX, destY].Figure = chess.Chess[srcX, srcY].Figure;
            chess.Chess[destX, destY].BackgroundImage = chess.Chess[srcX, srcY].BackgroundImage;
            chess.Chess[srcX, srcY].Figure = null;
            chess.Chess[srcX, srcY].BackgroundImage = null;
            return true;
        }
    }
}