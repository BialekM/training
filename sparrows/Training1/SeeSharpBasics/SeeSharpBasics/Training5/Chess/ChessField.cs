﻿using System.Windows.Forms;

namespace SeeSharpBasics.Training5.Chess
{
    public class ChessField: Button
    {
        public bool Colour; //true biale false czarne
        public int X;
        public int Y;
        public Figure Figure;
    }
}