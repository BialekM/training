using System;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekNowinski.Trening5.Chess
{
    public class SNKing : SNQueen
    {
        public bool Move(int srcX, int srcY, int destX, int destY, SNChessBord chess)
        {
            if (Math.Abs(destX - srcX) == 1 || Math.Abs(destY - srcY) == 1)
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
            return false;
        }
    }
}