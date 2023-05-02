using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rows, rows];

            ReadMatrix(matrix);

            while (true)
            {
                string command = Console.ReadLine();
                int row = -1;
                int column = -1;    
                if (command == "left")
                {
                    (row,column) = returnCordinates(matrix);
                    if (HasValidCordinates(row, column, matrix))
                    {

                    }
                }
                else if (command == "right")
                {

                }
                else if (command == "down")
                {

                }
                else if (command == "up")
                {

                }
            }


        }

        static public void Move(int row,int col,string direction, char[,] matrix)
        {
            if (direction == "left")
            {
                if (HasValidCordinates(row, col - 1, matrix))
                {
                    char getChar = matrix[row, col - 1];
                    if (getChar == 'T') //trap
                    {
                        matrix[row, col - 1] = '-';
                    }
                    else if (getChar == 'B') // bonus
                    {
                        matrix[row, col] = '-';
                        matrix[row, col - 1] = 'f';
                    }
                }
                else
                {
                    char getChar = matrix[row, matrix.GetLength(1)-1];
                    if (getChar == 'T') //trap
                    {
                        matrix[row, matrix.GetLength(1)-1] = '-';
                    }
                    else if (getChar == 'B') // bonus
                    {
                        matrix[row, col] = '-';
                        matrix[row, matrix.GetLength(1) - 1] = 'f';
                        
                    }
                }


            }
            else if (direction == "right")
            {

            }
            else if (direction == "down")
            {

            }
            else if (direction == "up")
            {

            }
            PrintMatrix(matrix);
        }

        static public (int, int) returnCordinates(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'f')
                    {
                        return (i, j);
                    }
                }
            }
            return (-1,-1);
        }

        static bool HasValidCordinates(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
            col >= 0 && col < matrix.GetLength(1);
        }


        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                   
                }
            }
        }
    }
}
