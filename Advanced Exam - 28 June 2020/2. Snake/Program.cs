using System;
using System.Linq;

namespace _2._Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix;
            int rowSnake, colSnake;
            int foodCount = 0;
            CreateMatrix(out matrix, out rowSnake, out colSnake);
            ReadMatrix(matrix);
            PrintMatrix(matrix);
            FindTheSnake(matrix);



            while (HasValidCordinates(rowSnake, colSnake, matrix))
            {
                string direction = Console.ReadLine();
                if (direction == "left")
                {
                    char nextChar = matrix[rowSnake, colSnake-1];
                    if(nextChar == '*') //food
                    {
                        foodCount++;
                    }
                    else if(nextChar == 'B') //teleport
                    {
                        int otherTeleportRow;
                        int otherTeleportCol;
                        (otherTeleportRow,otherTeleportCol)=FindTheOtherTeleport(matrix,rowSnake,colSnake-1);
                        matrix[rowSnake, colSnake] = '.';
                        matrix[rowSnake, colSnake-1] = '.';
                        matrix[otherTeleportRow,otherTeleportCol]='S';
                        continue;
                    }
                    matrix[rowSnake, colSnake] = '.';
                    colSnake++;
                    matrix[rowSnake, colSnake] = 'S';
                }
                else if (direction == "right")
                {

                }
                else if (direction == "up")
                {

                }
                else if (direction == "down")
                {

                }



            }


        }


        private static (int,int) FindTheOtherTeleport(char[,] matrix,int row,int col)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]=='B' && matrix[i, j] != matrix[row, col])
                    {
                        return (i, j);
                    }
                }
            }
            return (-1,-1);
        } 

        private static void CreateMatrix(out char[,] matrix, out int rowSnake, out int colSnake)
        {
            int size = int.Parse(Console.ReadLine());
            matrix = new char[size, size];
            rowSnake = 0;
            colSnake = 0;
        }

        static (int,int) FindTheSnake(char[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'S')
                    {
                        return (i,j);
                    }
                }
            }

            return (-1,-1);
        }

        static bool HasValidCordinates(int row,int col, char[,] matrix)
        {
            return row >= 0 && row <= matrix.GetLength(0) &&
            col >= 0 && col <= matrix.GetLength(1);
        }


        private static void ReadMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLongLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
