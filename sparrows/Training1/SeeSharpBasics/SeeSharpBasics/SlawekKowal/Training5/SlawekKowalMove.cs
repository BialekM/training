using System.Collections;
using SeeSharpBasics.Training5.Chess;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public static class SlawekKowalMove
    {
        private static Figure _helpx;
        private static Figure _helpy;
        public static void CanMoveDiagonally(ChessField source, ChessBoard helpChessBoard)
        {

            //Button[,] helpChessBoard.Chess = new Button[8,8];
            int x = source.X - 1;
            int y = source.Y - 1;

            while (x > 0 && y > 0)
            {
                x--;
                y--;
                if (helpChessBoard.Chess[(x), (y)].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;

                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                }

                break;
            }
            x = source.X - 1;
            y = source.Y - 1;
            while (x < 7 && y > 0)
            {
                x++;
                y--;
                if (helpChessBoard.Chess[x, y].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                    helpChessBoard.Chess[x, y].Enabled = true;
                break;
            }
            x = source.X - 1;
            y = source.Y - 1;
            while (x > 0 && y < 7)
            {
                x--;
                y++;
                if (helpChessBoard.Chess[x, y].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                    helpChessBoard.Chess[x, y].Enabled = true;
                break;
            }

            x = source.X - 1;
            y = source.Y - 1;
            while (x < 7 && y < 7)
            {
                x++;
                y++;
                if (helpChessBoard.Chess[x, y].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                    helpChessBoard.Chess[x, y].Enabled = true;
                break;
            }
        }



        public static void CanMoveVerHor(ChessField source, ChessBoard helpChessBoard)
        {
            int x = source.X - 1;
            int y = source.Y - 1;
            while (y > 0)
            {
                y--;
                if (helpChessBoard.Chess[x, y].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                    helpChessBoard.Chess[x, y].Enabled = true;
                break;
            }

            x = source.X - 1;
            y = source.Y - 1;
            while (x > 0)
            {
                x--;
                if (helpChessBoard.Chess[x, y].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                    helpChessBoard.Chess[x, y].Enabled = true;
                break;
            }

            x = source.X - 1;
            y = source.Y - 1;
            while (y < 7)
            {
                y++;
                if (helpChessBoard.Chess[x, y].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                    helpChessBoard.Chess[x, y].Enabled = true;
                break;
            }

            x = source.X - 1;
            y = source.Y - 1;
            while (x < 7)
            {
                x++;
                if (helpChessBoard.Chess[x, y].Figure == null)
                {
                    helpChessBoard.Chess[x, y].Enabled = true;
                    continue;
                }
                if ((helpChessBoard.Chess[x, y].Figure.Colour != source.Figure.Colour))
                    helpChessBoard.Chess[x, y].Enabled = true;
                break;
            }
        }

        public static void MovePawn(ChessField source, ChessBoard helpChessBoard)
        {

            int x = source.X - 1;
            int y = source.Y - 1;
            _helpx = source.Figure; ;
            _helpy = default(Figure);

            switch (source.Figure.Colour)
            {
                case false:
                    if (y == 1)
                    {
                        helpChessBoard.Chess[x, y + 1].Enabled = (helpChessBoard.Chess[x, y + 1].Figure == null && helpChessBoard.Chess[x, y + 2].Figure == null);
                        helpChessBoard.Chess[x, y + 2].Enabled = (helpChessBoard.Chess[x, y + 1].Figure == null && helpChessBoard.Chess[x, y + 2].Figure == null);
                    }
                    if (y + 1 < 7)
                    {
                        _helpy = helpChessBoard.Chess[x, y + 1].Figure;
                        helpChessBoard.Chess[x, y + 1].Enabled = _helpy == null;

                        _helpy = x > 0 ? helpChessBoard.Chess[x - 1, y + 1].Figure : null;
                        if (_helpy != null) helpChessBoard.Chess[x - 1, y + 1].Enabled = x - 1 >= 0 && _helpy.Colour != _helpx.Colour;

                        _helpy = x < 7 ? helpChessBoard.Chess[x + 1, y + 1].Figure : null;
                        if (_helpy != null) helpChessBoard.Chess[x + 1, y + 1].Enabled = x + 1 < 8 && _helpy.Colour != _helpx.Colour;
                    }
                    break;

                case true:
                    if (y == 6)
                    {
                        if (helpChessBoard.Chess[x, y - 1].Figure == null && helpChessBoard.Chess[x, y - 2].Figure == null)
                        {
                            helpChessBoard.Chess[x, y - 1].Enabled = true;
                            helpChessBoard.Chess[x, y - 2].Enabled = true;
                        }
                    }
                    if (y - 1 > 0)
                    {
                        _helpy = x > 0 ? helpChessBoard.Chess[x - 1, y - 1].Figure : null;
                        if (_helpy != null) helpChessBoard.Chess[x - 1, y - 1].Enabled = x - 1 >= 0 && _helpy.Colour != _helpx.Colour;
                        _helpy = helpChessBoard.Chess[x, y - 1].Figure;
                        helpChessBoard.Chess[x, y - 1].Enabled = _helpy == null;
                        _helpy = x < 7 ? helpChessBoard.Chess[x + 1, y - 1].Figure : null;
                        if (_helpy != null) helpChessBoard.Chess[x + 1, y - 1].Enabled = x + 1 < 8 && _helpy.Colour != _helpx.Colour;
                    }
                    break;
            }
        }

        public static void MoveKing(ChessField source, ChessBoard helpChessBoard)
        {
            int x = source.X - 1;
            int y = source.Y - 1;



            _helpx = source.Figure; ;
            _helpy = default(Figure);
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (i >= 0 && i < 8 && j >= 0 && j < 8)
                    {
                        _helpy = helpChessBoard.Chess[i, j].Figure;
                        helpChessBoard.Chess[i, j].Enabled = (_helpy == _helpx) || _helpy == null || _helpx.Colour != _helpy.Colour;
                    }
                }
            }
        }



        public static void MoveKnight(ChessField source, ChessBoard helpChessBoard)
        {
            Hashtable xx = new Hashtable();

            int x = source.X - 1;
            int y = source.Y - 1;
            xx.Clear();
            xx.Add(1, x - 1 >= 0 && y - 2 >= 0);
            xx.Add(2, x - 1 >= 0 && y + 2 <= 7);
            xx.Add(3, x + 1 <= 7 && y - 2 >= 0);
            xx.Add(4, x + 1 <= 7 && y + 2 <= 7);
            xx.Add(5, x - 2 >= 0 && y - 1 >= 0);
            xx.Add(6, x - 2 >= 0 && y + 1 <= 7);
            xx.Add(7, x + 2 <= 7 && y - 1 >= 0);
            xx.Add(8, x + 2 <= 7 && y + 1 <= 7);
            _helpx = source.Figure;


            for (int i = 1; i < 9; i++)
            {
                if ((bool)xx[i])
                {
                    switch (i)
                    {
                        case 1:
                            _helpy = helpChessBoard.Chess[x - 1, y - 2].Figure;
                            helpChessBoard.Chess[x - 1, y - 2].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;
                        case 2:
                            _helpy = helpChessBoard.Chess[x - 1, y + 2].Figure;
                            helpChessBoard.Chess[x - 1, y + 2].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;
                        case 3:
                            _helpy = helpChessBoard.Chess[x + 1, y - 2].Figure;
                            helpChessBoard.Chess[x + 1, y - 2].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;
                        case 4:
                            _helpy = helpChessBoard.Chess[x + 1, y + 2].Figure;
                            helpChessBoard.Chess[x + 1, y + 2].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;
                        case 5:
                            _helpy = helpChessBoard.Chess[x - 2, y - 1].Figure;
                            helpChessBoard.Chess[x - 2, y - 1].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;
                        case 6:
                            _helpy = helpChessBoard.Chess[x - 2, y + 1].Figure;
                            helpChessBoard.Chess[x - 2, y + 1].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;
                        case 7:
                            _helpy = helpChessBoard.Chess[x + 2, y - 1].Figure;
                            helpChessBoard.Chess[x + 2, y - 1].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;
                        case 8:
                            _helpy = helpChessBoard.Chess[x + 2, y + 1].Figure;
                            helpChessBoard.Chess[x + 2, y + 1].Enabled = (_helpy == null || _helpx.Colour != _helpy.Colour); break;

                    }
                }
            }






        }

    }
}