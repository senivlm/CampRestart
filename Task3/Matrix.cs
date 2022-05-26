using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Matrix
    {
        private int rowCount;
        private int colCount;
        private int[,] matrSquare;

        public void SpiralFulling(int[,] matr)
        {
            int number = 0;
            for (int j = 0; j < (matr.GetLength(0) + matr.GetLength(1)) / 2 - 2; j++)
            {
                for (int i = j; i < matr.GetLength(0) - j; i++)
                {
                    matr[i, j] = ++number;
                }
                for (int i = j + 1; i < matr.GetLength(1) - j - 1; i++)
                {
                    matr[i, matr.GetLength(0) - 1 - j] = ++number;
                }
                for (int i = matr.GetLength(1) - 1 - j; i > j; i--)
                {
                    matr[j, i] = ++number;
                }
            }
        }
        public void Print(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
