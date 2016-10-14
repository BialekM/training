using System;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekNowinski.Trening5.Chess
{
    public class SNQueen : SNFigure
    {
        public override bool Move(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (RookMove(srcX, srcY, destX, destY, chess))
            {
                return true;
            }
            if (BishopMove(srcX, srcY, destX, destY, chess))
            {
                return true;
            }
            return false;

        }

        protected bool RookMove(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (srcX == destX && srcY != destY)
            {
                yAxis(srcX, srcY, destX, destY, chess);
            }
            if (srcX != destX && srcY == destY)
            {
                yAxis(srcX, srcY, destX, destY, chess);
            }
            if (((srcX != destX && srcY == destY) || (srcX == destX && srcY != destY)) && isFigure(destX, destY, chess))
            {
                if (!isTheSameColor(destX, destY, color, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
            }
            return false;
        }

        private bool yAxis(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            for (int i = 0; i <= Math.Abs(destY - srcY); i++)
            {
                if (!isFigure(srcX, srcY + i, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if (!isFigure(srcX, srcY - i, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
            }
            return false;
        }

        private bool xAxis(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            for (int i = 0; i <= Math.Abs(destX - srcX); i++)
            {
                if (!isFigure(srcX + i, srcY, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if (!isFigure(srcX - i, srcY, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
            }
            return false;
        }

        protected bool BishopMove(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            for (int i = 0; i <= destX - srcX; i++)
            {

                if ((srcX + i == srcY + i) && !isFigure(srcX + i, srcY + i, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if ((srcX - i == srcY + i) && !isFigure(srcX - i, srcY + i, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if ((srcX - i == srcY - i) && !isFigure(srcX - i, srcY - i, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if ((srcX + i == srcY - i) && !isFigure(srcX + i, srcY - i, chess))
                {
                    chess.Chess[destX, destY].Figure = this;
                    return true;
                }
                if (Math.Abs(destX - srcX) == Math.Abs(destY - srcY) && isFigure(destX, destY, chess))
                {
                    if (!isTheSameColor(destX, destY, color, chess))
                    {
                        chess.Chess[destX, destY].Figure = this;
                        return true;
                    }
                }

            }
            return false;
        }
    }
}