using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Selling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            ReadMatrix(matrix);

            int playerRow = 0;
            int playerCol = 0;  
            (playerRow,playerCol)=FindPlayerPosition(matrix);

            int firstTeleportRow=0;
            int firstTeleportCol=0;
            (firstTeleportCol, firstTeleportCol) = FirstTeleport(matrix);

            int secondTeleportRow=0;
            int secondTeleportCol=0;
            (secondTeleportRow, secondTeleportCol) = SecondTeleport(matrix, firstTeleportRow, firstTeleportCol);

            int dollars = 0;
            List<int> collection = new List<int>();
            string outOfBoundsMessage = "Bad news, you are out of the bakery.";
            while (HasValidCordinates(matrix, playerRow, playerCol) || collection.Sum()<50)
            {
                string direction = Console.ReadLine();
                if (direction == "up")
                {
                    if (!HasValidCordinates(matrix, playerRow - 1, playerCol))
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine(outOfBoundsMessage);
                        break;

                    }
                    matrix[playerRow, playerCol] = '-';
                    playerRow--;
                    char getCurrentElement =matrix[playerRow, playerCol];
                    if (getCurrentElement != 'O' || getCurrentElement != '-')
                    {
                        int add = int.Parse(matrix[playerRow, playerCol].ToString());
                        collection.Add(add);
                    }
                    else if (getCurrentElement == 'O')
                    {
                        matrix[playerRow, playerCol] = '-';
                        if (matrix[playerRow, playerCol] == matrix[firstTeleportRow, firstTeleportCol])
                        {
                            playerRow = secondTeleportRow;
                            playerCol = secondTeleportCol;
                        }
                        else
                        {
                            playerRow = firstTeleportRow;
                            playerCol = firstTeleportCol;
                        }
                    }
                    matrix[playerRow, playerCol] = 'S';
                }
                else if (direction == "down")
                {
                    if (!HasValidCordinates(matrix, playerRow + 1, playerCol))
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine(outOfBoundsMessage);
                        break;

                    }
                    matrix[playerRow, playerCol] = '-';
                    playerRow++;
                    char getCurrentElement = matrix[playerRow, playerCol];
                    if (getCurrentElement != 'O' && getCurrentElement != '-')
                    {
                        int add = int.Parse(matrix[playerRow, playerCol].ToString());
                        collection.Add(add);
                    }
                    else if (getCurrentElement == 'O')
                    {
                        matrix[playerRow, playerCol] = '-';
                        if (matrix[playerRow, playerCol] == matrix[firstTeleportRow, firstTeleportCol])
                        {
                            playerRow = secondTeleportRow;
                            playerCol = secondTeleportCol;
                        }
                        else
                        {
                            playerRow = firstTeleportRow;
                            playerCol = firstTeleportCol;
                        }
                    }
                    matrix[playerRow, playerCol] = 'S';
                }
                else if (direction == "left")
                {
                    if (!HasValidCordinates(matrix, playerRow, playerCol-1))
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine(outOfBoundsMessage);
                        break;

                    }
                    matrix[playerRow, playerCol] = '-';
                    playerCol--;
                    char getCurrentElement = matrix[playerRow, playerCol];
                    if (getCurrentElement != 'O' && getCurrentElement != '-')
                    {
                        int add = int.Parse(matrix[playerRow, playerCol].ToString());
                        collection.Add(add);
                    }
                    else if (getCurrentElement == 'O')
                    {
                        matrix[playerRow, playerCol] = '-';
                        if (matrix[playerRow, playerCol] == matrix[firstTeleportRow, firstTeleportCol])
                        {
                            playerRow = secondTeleportRow;
                            playerCol = secondTeleportCol;
                        }
                        else
                        {
                            playerRow = firstTeleportRow;
                            playerCol = firstTeleportCol;
                        }
                    }
                    matrix[playerRow, playerCol] = 'S';
                }
                else if (direction == "right")
                {
                    if (!HasValidCordinates(matrix, playerRow, playerCol+1))
                    {
                        matrix[playerRow, playerCol] = '-';
                        Console.WriteLine(outOfBoundsMessage);
                        break;
                    }
                    matrix[playerRow, playerCol] = '-';
                    playerCol++;
                    char getCurrentElement = matrix[playerRow, playerCol];
                    if (getCurrentElement != 'O' && getCurrentElement != '-')
                    {
                        int add = int.Parse(matrix[playerRow, playerCol].ToString());
                        collection.Add(add);
                    }
                    else if (getCurrentElement == 'O')
                    {
                        matrix[playerRow, playerCol] = '-';
                        if (matrix[playerRow, playerCol] == matrix[firstTeleportRow, firstTeleportCol])
                        {
                            playerRow = secondTeleportRow;
                            playerCol = secondTeleportCol;
                        }
                        else
                        {
                            playerRow = firstTeleportRow;
                            playerCol = firstTeleportCol;
                        }
                    }
                    matrix[playerRow, playerCol] = 'S';
                }


                if (collection.Sum() >= 50)
                {
                    break;
                }
            }



            if (collection.Sum() >= 50)
            {
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {collection.Sum()}");
            PrintMatrix(matrix);
        }

        public static bool HasValidCordinates(char[,] matrix,int row,int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
        private static (int,int) FindPlayerPosition(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'S')
                    {
                        return (i, j);
                    }
                }
            }
            return (-1,-1);
        }

        private static (int, int) FirstTeleport(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'O')
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1);
        }

        private static (int, int) SecondTeleport(char[,] matrix,int firstRow,int firstCol)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'O' && i!=firstRow && j!=firstCol)
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1);
        }



        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] inputArr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < inputArr.Length; j++)
                {
                    matrix[i, j] = inputArr[j];
                }
            }
        }
    }
}
