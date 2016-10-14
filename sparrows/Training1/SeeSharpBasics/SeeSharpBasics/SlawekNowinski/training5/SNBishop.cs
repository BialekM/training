using System;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekNowinski.Trening5.Chess
{
    public class SNBishop : SNFigure
    {

        public override bool Move(int srcX, int srcY, int destX, int destY, SNChessBord chess)
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