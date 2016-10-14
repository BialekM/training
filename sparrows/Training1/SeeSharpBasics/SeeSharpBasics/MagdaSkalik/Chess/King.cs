using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.MagdaSkalik.Chess
{
    public class King : Figure
    {
        public override bool Move(int srcX, int srcY, int destX, int destY, ChessBoard chess)
        {
            return (destX == (srcX-1) || destY == (srcY + 1) || destX == (srcX + 1) || (destY == (srcY+1) && destX == (srcX - 1)) || (destY == (srcY + 1) && destX == (srcX + 1)));
        }
    }
}
