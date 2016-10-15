using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeeSharpBasics.MagdaSkalik.Chess
{
    public abstract class Figure
    {
        public bool Colour;

        public abstract bool Move(int srcX, int srcY, int destX, int destY, ChessBoard chess);

        protected virtual bool CanOccupy(ChessField source, ChessField destination, bool isFinalField)
        {
            if (source.Figure is Knight)
            {
                isFinalField = true;
            }

            return false;
        }
    }
}
