using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekNowinski.Trening5.Chess
{
    public class SNKnight : SNFigure
    {
        public override bool Move(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if ((srcX + 2 == destX && srcY + 1 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            if ((srcX + 2 == destX && srcY - 1 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            if ((srcX - 2 == destX && srcY + 1 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            if ((srcX - 2 == destX && srcY - 1 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            if ((srcX + 1 == destX && srcY + 2 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            if ((srcX + 1 == destX && srcY - 2 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            if ((srcX - 1 == destX && srcY + 2 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            if ((srcX - 1 == destX && srcY - 2 == destY) && isGood(destX, destY, chess))
            {
                return true;
            }
            return false;

        }

        private bool isGood(int destX, int destY, SNChessBord chess)
        {
            if (isFigure(destX, destY, chess))
            {
                if (!isTheSameColor(destX, destY, color, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if (isTheSameColor(destX, destY, color, chess))
                {

                    return false;
                }
            }
            else
            {
                chess.Chess[destX, destY].Figure = this;
                return true;
            }
            return true;
        }
    }
}