using System;

namespace SeeSharpBasics.Training3.Homework.AndrzejIwanski
{
    public class AndrzejIwanskiMineSweeper : MineSweeper
    {
        private int[,] FillWithBombs(int x, int y, int bomb)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int rndx, rndy;

            var field = new int[x, y];

            for (var i = 0; i < bomb;)
            {
                rndx = rnd.Next(0, x);
                rndy = rnd.Next(0, y);
                if (field[rndx, rndy] != -1)
                {
                    field[rndx, rndy] = -1;
                    i++;
                }
            }
            return field;
        }

        public void Draw(int[,] tab)
        {
            for (var i = 0; i < tab.GetLength(0); i++)
            {
                for (var j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("\t{0}", tab[j, i]);
                }
                Console.Write("\n");
            }
        }


        public override int[,] BombsCount(int dimx, int dimy, int bombsNumber)
        {
            var result = new int[dimx, dimy];
            result = FillWithBombs(dimx, dimy, bombsNumber);

            for (var i = 0; i < dimx; i++)
            {
                for (var j = 0; j < dimy; j++)
                {
                    if (result[i,j] != -1)
                    {
                        if (j > 0        && i > 0           &&  result[i - 1,   j - 1   ] == -1)    result[i, j]++;
                        if (j > 0        &&                     result[i,       j - 1   ] == -1)    result[i, j]++;
                        if (j > 0        && i < dimx - 1    &&  result[i + 1,   j - 1   ] == -1)    result[i, j]++;
                        if (                i > 0           &&  result[i - 1,   j       ] == -1)    result[i, j]++;
                        if (                i < dimx - 1    &&  result[i + 1,   j       ] == -1)    result[i, j]++;
                        if (j < dimy - 1 && i > 0           &&  result[i - 1,   j + 1   ] == -1)    result[i, j]++;
                        if (j < dimy - 1 &&                     result[i,       j + 1   ] == -1)    result[i, j]++;
                        if (j < dimy - 1 && i < dimx -1     &&  result[i + 1,   j + 1   ] == -1)    result[i, j]++;
                    }
                }
            }
            return result;
        }
    }
}