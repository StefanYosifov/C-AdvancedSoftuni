using System;
using System.Linq;

namespace _2._2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowColArr=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row=rowColArr[0];
            int col=rowColArr[1];

            char[,]matrix=new char[row,col];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] inputArr=Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for(int j=0; j < inputArr.Length; j++)
                {
                    matrix[i,j] = inputArr[j];
                }
            }

            int squareMatrixesCount = 0;

            for(int i=0; i < matrix.GetLength(0)-1; i++)
            {
                for(int j=0;j < matrix.GetLength(1)-1; j++)
                {
                    if(matrix[i,j] == matrix[i+1,j] && matrix[i,j]==matrix[i,j+1] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        squareMatrixesCount++;
                    }
                }
            }
            if (squareMatrixesCount == 0)
            {
                Console.WriteLine($"No 2 x 2 squares of equal cells exist.");
                return;
            }
            Console.WriteLine(squareMatrixesCount);

        }
    }
}



