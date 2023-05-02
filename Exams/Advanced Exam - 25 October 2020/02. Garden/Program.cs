using System;
using System.Linq;

namespace _02._Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrRowCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRow = arrRowCol[0];
            int matrixCol = arrRowCol[1];
            int[,] matrix = new int[matrixRow, matrixCol];
            ReadMatrix(matrix);
          

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "Bloom Bloom Plow")
            {
                if (command[0].StartsWith("Bloom"))
                {
                    break;
                }
                int row = int.Parse(command[0]);
                int col = int.Parse(command[1]);
                if (HasValidCordinates(row, col, matrix))
                {
                    int goUp = row;
                    while (HasValidCordinates(goUp, col, matrix))
                    {
                        matrix[goUp, col]++;
                        goUp--;
                    }
                  

                    int goDown = row+1;
                    while (HasValidCordinates(goDown, col, matrix))
                    {
                        matrix[goDown, col]++;
                        goDown++;
                    }
                   
                    int goLeft = col-1;
                    while (HasValidCordinates(row, goLeft, matrix))
                    {
                        matrix[row, goLeft]++;
                        goLeft--;
                    }
                    
                    int goRight = col+1;
                    while (HasValidCordinates(row, goRight, matrix))
                    {
                        matrix[row, goRight]++;
                        goRight++;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid coordinates.");

                }

                command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public static bool HasValidCordinates(int row, int col, int[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
    }
}
