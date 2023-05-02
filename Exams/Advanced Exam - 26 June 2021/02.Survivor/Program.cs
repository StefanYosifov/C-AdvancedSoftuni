using System;
using System.Linq;


namespace _02.Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[][] board = new char[size][];
            ReadJaggedArray(board);

            int playerCollectedCoins = 0;
            int enemyCollectedCoins = 0;

            string order = Console.ReadLine();
            while(order!= "Gong")
            {
                string[] orderArr = order.Split(' ').ToArray();
                string action=orderArr[0];
                int row = int.Parse(orderArr[1]);
                int col=int.Parse(orderArr[2]);

                if (action == "Find")
                {
                    if (HasValidCordinates(board, row, col))
                    {
                        char currentChar=CharAtCordinates(board, row, col);
                        if (currentChar == 'T')
                        {
                            playerCollectedCoins++;
                            board[row][col] = '-';
                        }
                    }
                }
                else if (action == "Opponent")
                {
                    string direction=orderArr[3];
                    int moves = 0;
                    while (HasValidCordinates(board, row, col) && moves<=3)
                    {
                        if (direction == "up")
                        {
                            char currentChar = board[row][col];
                            if (currentChar == 'T')
                            {
                                enemyCollectedCoins++;
                                board[row][col] = '-';
                            }
                            row--;
                        }
                        else if (direction == "down")
                        {
                            char currentChar = board[row][col];
                            if (currentChar == 'T')
                            {
                                enemyCollectedCoins++;
                                board[row][col] = '-';
                            }
                            row++;
                        }
                        else if (direction == "left")
                        {
                            char currentChar = board[row][col];
                            if (currentChar == 'T')
                            {
                                enemyCollectedCoins++;
                                board[row][col] = '-';
                            }
                            col--;
                        }
                        else if (direction == "right")
                        {
                            char currentChar = board[row][col];
                            if (currentChar == 'T')
                            {
                                enemyCollectedCoins++;
                                board[row][col] = '-';
                            }
                            col++;
                        }
                        moves++;
                    }


                }
                
                order = Console.ReadLine();
                
            }
            PrintJaggedArray(board);
            Console.WriteLine($"Collected tokens: {playerCollectedCoins}");
            Console.WriteLine($"Opponent's tokens: {enemyCollectedCoins}");

        }

        public static char CharAtCordinates(char[][]board,int row,int col)
        {
            return board[row][col];
        }


        public static bool HasValidCordinates(char[][] board,int row,int col)
        {
            if(row<0 || row >= board.Length)
            {
                return false;
            }
            if(col<0 || col >= board[row].Length)
            {
                return false;
            }
            return true;
        }

        private static void PrintJaggedArray(char[][] matrix)
        {
            foreach (var line in matrix)
            {
                var currentLine = string.Join(' ', line);
                Console.WriteLine(currentLine);
            }
        }

        private static void ReadJaggedArray(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }
        }
    }
}
