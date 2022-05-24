using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampRestart
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
        public void DiagonalFulling(int n)
        {
            matrSquare = new int[n, n];
            int number = 0;
            for (int line = 0; line < n; line++)
            {
                if (line % 2 == 0)
                {
                    int i1 = line;
                    int j1 = 0;
                    for (int i = 0; i < line + 1; i++)
                    {
                        matrSquare[i1, j1] = ++number;
                        i1--;
                        j1++;
                    }
                }
                else
                {
                    int i1 = 0;
                    int j1 = line;
                    for (int i = 0; i < line + 1; i++)
                    {
                        matrSquare[i1, j1] = ++number;
                        i1++;
                        j1--;
                    }
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
