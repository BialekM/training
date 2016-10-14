using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.MagdaSkalik.Chess
{
    public class Pawn : Figure
    {
        public override bool Move(int srcX, int srcY, int destX, int destY, ChessBoard chess)
        {
            return (srcX == destX && destY == (srcY + 1));
        }
    }
}
