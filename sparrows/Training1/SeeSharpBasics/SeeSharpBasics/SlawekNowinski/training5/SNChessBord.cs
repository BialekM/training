namespace SeeSharpBasics.SlawekNowinski.Trening5.Chess
{
    public class SNChessBord
    {
        public SNChessField[,] Chess = new SNChessField[8, 8];

        public SNChessBord()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Chess[i, j] = new SNChessField();
                    Chess[i, j].X = i + 1;
                    Chess[i, j].Y = j + 1;
                    Chess[i, j].Colour = (i + j) % 2 == 1;
                }
            }
        }
    }
}