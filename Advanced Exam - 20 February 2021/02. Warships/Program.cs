using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Warships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            int[] playerActions = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> playerMoves = new Queue<int>(playerActions);


            ReadMatrix(matrix);
           



            bool firstPlayerTurn = true;
            int firstPlayerShips = FirstPlayerShips(matrix);
            int secondPlayerShips = SecondPlayerShips(matrix);
            int total = firstPlayerShips + secondPlayerShips;

            while (playerMoves.Count > 0)
            {
                int row = playerMoves.Dequeue();
                int col = playerMoves.Dequeue();

                if (firstPlayerTurn)
                {
                    Console.WriteLine($"Entering first player");
                    firstPlayerTurn = false;
                    if (HasValidCordinates(matrix, row, col))
                    {
                        char currentChar = matrix[row, col];
                        if (currentChar == '>')
                        {
                            matrix[row, col] = 'X';
                            secondPlayerShips--;
                        }
                        else if (currentChar == '<')
                        {
                            matrix[row, col] = 'X';
                            firstPlayerShips--;
                        }
                        else if (currentChar == '#')
                        {
                            matrix[row, col] = 'X';
                            for (int i = -1; i < 2; i++)
                            {
                                for (int j = -1; j < 2; j++)
                                {
                                    if (HasValidCordinates(matrix, row + i, col + j))
                                    {
                                        char currentBombExplosion = GetCharacterAtCordinate(matrix, row + i, col + j);
                                        if (currentBombExplosion == '<')
                                        {
                                            firstPlayerShips--;
                                            matrix[row + i, col + j] = 'X';
                                        }
                                        else if (currentBombExplosion == '>')
                                        {
                                            secondPlayerShips--;
                                            matrix[row + i, col + j] = 'X';
                                        }

                                    }
                                }
                            }

                        }

                    }

                }
                else
                {
                    Console.WriteLine($"Entering second player");
                    firstPlayerTurn = true;

                    if (HasValidCordinates(matrix, row, col))
                    {
                        char currentChar = matrix[row, col];
                        if (currentChar == '>')
                        {
                            matrix[row, col] = 'X';
                            secondPlayerShips--;
                        }
                        else if (currentChar == '<')
                        {
                            matrix[row, col] = 'X';
                            firstPlayerShips--;
                        }
                        else if (currentChar == '#')
                        {
                            matrix[row, col] = 'X';
                            for (int i = -1; i < 2; i++)
                            {
                                for (int j = -1; j < 2; j++)
                                {
                                    if (HasValidCordinates(matrix, row + i, col + j))
                                    {
                                        char currentBombExplosion = GetCharacterAtCordinate(matrix, row + i, col + j);
                                        if (currentBombExplosion == '<')
                                        {
                                            firstPlayerShips--;
                                            matrix[row + i, col + j] = 'X';
                                        }
                                        else if (currentBombExplosion == '>')
                                        {
                                            secondPlayerShips--;
                                            matrix[row + i, col + j] = 'X';
                                        }
                                        

                                    }
                                }
                            }

                        }

                    }


                }
                
                if(firstPlayerShips == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {total-(firstPlayerShips+secondPlayerShips)} ships have been sunk in the battle.");
                    return;
                }
                else if(secondPlayerShips == 0)
                {
                    Console.WriteLine($"Player One has won the game! {total - (firstPlayerShips + secondPlayerShips)} ships have been sunk in the battle.");
                    return;
                }
                
            }

            Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }

        private static void printMatrix(char[,] matrix)
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

        public static int FirstPlayerShips(char[,] board)
        {
            int count = 0;
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j=0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '<')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int SecondPlayerShips(char[,] board)
        {
            int count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '<')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static char GetCharacterAtCordinate(char[,] board,int row,int col)
        {
            return board[row,col];
        }

        public static bool HasValidCordinates(char[,] board,int row,int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                   col >= 0 && col < board.GetLength(1);
        }
    }
}
