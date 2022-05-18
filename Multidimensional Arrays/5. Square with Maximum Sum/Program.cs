using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            for(int i=0;i<matrix.GetLength(0); i++)
            {
                int[] addToMatirx = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for(int j=0;j<addToMatirx.Length; j++)
                {
                    matrix[i,j]=addToMatirx[j];
                }
            }
            int sum = 0;
            int biggestSum = int.MinValue;

            int[,] printMatrix = new int[2, 2];
            for(int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for(int j=0;j<matrix.GetLength(1)-1; j++)
                {
                    sum = matrix[i, j] + matrix[i + 1,j]+matrix[i,j+1]+matrix[i+1,j+1];
                    if(sum> biggestSum)
                    {
                        printMatrix[0, 0] = matrix[i, j];
                        printMatrix[1, 0] = matrix[i + 1, j];
                        printMatrix[0,1]= matrix[i, j + 1];
                        printMatrix[1, 1] = matrix[i + 1, j + 1];
                        biggestSum = sum;
                    }
                    
                   
                }
            }

            for(int i = 0; i < printMatrix.GetLength(0); i++)
            {
                for(int j=0;j<printMatrix.GetLength(1); j++)
                {
                    Console.Write($"{printMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);
        }
    }
}
