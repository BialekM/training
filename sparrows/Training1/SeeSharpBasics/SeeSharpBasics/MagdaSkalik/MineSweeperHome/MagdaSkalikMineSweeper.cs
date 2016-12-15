using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpBasics.Training3.Homework;
using System.Diagnostics;

namespace SeeSharpBasics.MagdaSkalik.MineSweeperHome
{
    class MagdaSkalikMineSweeperHome : MineSweeper
    {
        private const int bomb = -1;
        public override int[,] BombsCount(int dimx, int dimy, int bombsNumber)
        {
            int[,] bombsMap = new int[dimx, dimy];
            int randomX = 0;
            int randomY = 0;

            Random rnd = new Random(DateTime.Now.Millisecond);
            while(bombsNumber >0)
            {
                randomX = rnd.Next(0, dimx - 1);
                randomY = rnd.Next(0, dimy - 1);

                if(bombsMap[randomX,randomY] != bomb)
                {
                    bombsMap[randomX, randomY] = bomb;
                    bombsNumber--;
                }
            }

            return bombsMap;

        }

        public void Show(int[,]bombsMap)
        {
            for(int i =0; i< bombsMap.GetLength(0) - 1;i++)
            {
                for (int j = 0; j < bombsMap.GetLength(1)-1; j++)
                {
                    Console.Write(" {0} ", bombsMap[i,j]);
                }
                Console.WriteLine("");

            }
        }
    }
}
