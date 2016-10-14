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
            return (destY == (srcY-1));
        }
    }
}
