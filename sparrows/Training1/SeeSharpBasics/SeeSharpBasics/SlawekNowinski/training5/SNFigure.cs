using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekNowinski.Trening5.Chess
{

    public abstract class SNFigure
    {
        public bool color;

        public abstract bool Move(int srcX, int srcY, int destX, int destY, SNChessBord chess);

        public virtual bool isFigure(int srcX, int srcY, SNChessBord chess)
        {

            if (chess.Chess[srcX, srcY] != null)
            {
                return true;
            }
            return false;
        }

        public virtual bool isTheSameColor(int srcX, int srcY, bool color, SNChessBord chess)
        {
            if (chess.Chess[srcX, srcY].Colour == color)
            {
                return true;
            }
            return false;
        }
    }
}