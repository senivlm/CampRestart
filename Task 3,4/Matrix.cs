using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3And4
{
    internal class Matrix
    {
        private int rowCount;
        private int colCount;
        
        private int[,] matrSquare;

        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < matrSquare.GetLength(0); i++)
            {
                for (int j = 0; j < matrSquare.GetLength(1); j++)
                {
                    line += matrSquare[i, j] + " ";
                }
                line += '\n';
            }
            return line;
        }

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
        
        public void Print()
        {
            for (int i = 0; i < matrSquare.GetLength(0); i++)
            {
                for (int j = 0; j < matrSquare.GetLength(1); j++)
                {
                    Console.Write(matrSquare[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public void ReadMatrixFromFile(StreamReader reader)
        {
            string line = reader.ReadLine();
            string[] sizes = line.Split(' ');
            
            this.rowCount = int.Parse(sizes[0]);
            this.colCount = int.Parse(sizes[1]);

            matrSquare = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] items = reader.ReadLine().Split(' ');
                for (int j = 0; j < colCount; j++)
                {
                    matrSquare[i, j] = int.Parse(items[j]);
                }
            }

        }
    }
}
