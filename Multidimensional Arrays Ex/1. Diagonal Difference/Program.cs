using System;
using System.Linq;

namespace _01.Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arrInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < arrInput.Length; j++)
                {
                    matrix[i, j] = arrInput[j];
                }
            }

            int firstDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        firstDiagonal += matrix[i, j];
                    }
                }
            }

            int leftDiagonal = matrix.GetLength(1) - 1;
            int secondDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == leftDiagonal)
                    {
                        secondDiagonal += matrix[i, j];
                    }
                }
                leftDiagonal--;
            }

            int result = Math.Abs(firstDiagonal - secondDiagonal);
            Console.WriteLine(result);
        }


    }
}