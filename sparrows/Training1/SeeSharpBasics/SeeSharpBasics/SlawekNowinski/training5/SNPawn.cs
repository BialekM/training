using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekNowinski.Trening5.Chess
{
    public class SNPawn : SNFigure
    {
        public override bool Move(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (color)
            {
                if (srcY == 2 && FirstWhiteMove(srcX, srcY, destX, destY, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if (WhiteColor(srcX, srcY, destX, destY, chess))
                {
                    return true;
                }
                return false;
            }
            if (!color)
            {
                if (srcY == 2 && FirstBlackMove(srcX, srcY, destX, destY, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if (BlackColor(srcX, srcY, destX, destY, chess))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool WhiteColor(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (destX == srcX + 1)
            {
                if ((destY == srcY - 1 || destY == srcY + 1) && isFigure(destX, destY, chess) &&
                    !isTheSameColor(destX, destY, color, chess))
                {
                    return true;
                }
                if (destY == srcY && !isFigure(destX, destY, chess))
                {
                    return true;
                }
            }
            return false;

        }

        private bool BlackColor(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (destX == srcX - 1)
            {
                if ((destY == srcY - 1 || destY == srcY + 1) && isFigure(destX, destY, chess) &&
                    !isTheSameColor(destX, destY, color, chess))
                {
                    return true;
                }
                if (destY == srcY && !isFigure(destX, destY, chess))
                {
                    return true;
                }
            }
            return false;

        }

        private bool FirstWhiteMove(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (destX == 3)
            {
                if ((destY == srcY - 1 || destY == srcY + 1) && isFigure(destX, destY, chess) &&
                    !isTheSameColor(destX, destY, color, chess))
                {
                    return true;
                }
                if (destY == srcY && !isFigure(destX, destY, chess))
                {
                    return true;
                }
            }
            if (destX == 4)
            {
                if (destY == srcY && !isFigure(destX, destY, chess) && !isFigure(destX - 1, destY, chess))
                {
                    return true;
                }
            }
            return false;
        }

        private bool FirstBlackMove(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (destX == 6)
            {
                if ((destY == srcY - 1 || destY == srcY + 1) && isFigure(destX, destY, chess) &&
                    !isTheSameColor(destX, destY, color, chess))
                {
                    return true;
                }
                if (destY == srcY && !isFigure(destX, destY, chess))
                {
                    return true;
                }
            }
            if (destX == 5)
            {
                if (destY == srcY && !isFigure(destX, destY, chess) && !isFigure(destX - 1, destY, chess))
                {
                    return true;
                }
            }
            return false;
        }
    }
}