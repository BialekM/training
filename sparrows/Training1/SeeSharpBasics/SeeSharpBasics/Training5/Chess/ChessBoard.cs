namespace SeeSharpBasics.Training5.Chess
{
    public class ChessBoard
    {
        public ChessField[,] Chess = new ChessField[8,8];

        public ChessBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Chess[i,j] = new ChessField();
                    Chess[i, j].X = i + 1;
                    Chess[i, j].Y = j + 1;
                    Chess[i, j].Colour = (i + j) % 2 == 1;
                }
            }
        }
    }
}