using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Matrix
{
   
    class MyMatrix
    {
        int[][] matrix;
        Random rand = new Random();
        public MyMatrix(int NLine, int MColumn)
        {
            matrix = new int[NLine][];
            for (int i = 0; i < NLine; i++)
            {
                matrix[i] = new int[MColumn];
            }
            Fill();
        }

        void Fill()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rand.Next(10, 99);
                }
            }
        }
        public void ChangeMatrix(int row, int col)
        {
            if (row < 0||col < 0)
            {
                Console.WriteLine("Размеры матрици не могут быть меньшими или равными нулю");
                return;
            }
            var newMatrix = new int[row] [];
            for (int i = 0; i < row; i++)
            {
                newMatrix[i] = new int[col];
            }
            for (int i = 0; i < Math.Min(row, matrix.Length); i++)
            {
                for (int j = 0; j < Math.Min(col,matrix[i].Length); j++)
                {
                    newMatrix[i][j] = matrix[i][j];
                }
            }

            if (col > matrix[0].Length)
            {
                for (int i = 0; i < newMatrix.Length; i++)
                {
                    for (int j = matrix[0].Length; j < newMatrix[i].Length; j++)
                    {
                        newMatrix[i][j] = rand.Next(10, 99);
                    }
                }
            }

            if (row > matrix.Length)
            {
                for (int i = matrix.Length; i < newMatrix.Length; i++)
                {
                    for (int j = 0; j < newMatrix[i].Length; j++)
                    {
                        newMatrix[i][j] = rand.Next(10, 99);
                    }
                }
            }
            matrix = newMatrix;
        } 

        public void showPartMatrix(int startRow, int startCol, int finshRow, int finishCol)
        {
            for (int i = startRow; i < finshRow; i++)
            {
                for (int j = startCol; j < finishCol; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int this[int i, int j]
        {
            get { return matrix[i][j]; }
            set { matrix[i][j] = value; }
        }

        public void ShowLength()
        {
            Console.WriteLine("NLine = {0}",matrix.Length);
            Console.WriteLine("NColume = {0}", matrix[1].Length);
        }
    }
}
