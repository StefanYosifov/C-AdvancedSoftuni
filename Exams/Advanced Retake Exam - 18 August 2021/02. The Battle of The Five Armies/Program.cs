using System;
using System.Linq;

namespace _02._The_Battle_of_The_Five_Armies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] board = new char[rows][];

            ReadJaggedArray(board);
           

            int armyRow = 0;
            int armyCol = 0;
            (armyRow, armyCol) = FindTheTroop(board);

            while (true)
            {
                string[] action = Console.ReadLine().Split(' ').ToArray();
                string direction = action[0];
                int enemyRow = int.Parse(action[1]);
                int enemyCol = int.Parse(action[2]);
                board[enemyRow][enemyCol] = 'O';

                if (direction == "up")
                {
                    if (ValidCordinates(armyRow - 1, armyCol, board)) // If board is valid
                    {
                        if (board[armyRow - 1][armyCol] == 'O') // If next is enemy
                        {
                            if (health >= 3)
                            {
                                health -= 2;
                                board[armyRow][armyCol] = '-';
                                armyRow--;
                                board[armyRow][armyCol] = 'A';
                            }
                            else
                            {
                                board[armyRow][armyCol] = 'X';
                                printLossingMessage(armyRow, armyCol);
                            }

                        }
                        else if (board[armyRow - 1][armyCol] == 'M') // Win condition
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            board[armyRow - 1][armyCol] = '-';
                            printWinningMessage(health);
                            return;
                        }
                        else if (board[armyRow - 1][armyCol] == '-') // No obstacles '-'
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            armyRow--;
                            board[armyRow][armyCol] = 'A';
                        }
                    }
                    else // If outside the board remove health only
                    {
                        health--;
                    }
                }
                else if (direction == "down")
                {
                    if (ValidCordinates(armyRow + 1, armyCol, board)) // If board is valid
                    {
                        if (board[armyRow + 1][armyCol] == 'O') // If next is enemy
                        {
                            if (health >= 3)
                            {
                                health -= 2;
                                board[armyRow][armyCol] = '-';
                                armyRow++;
                                board[armyRow][armyCol] = 'A';
                            }
                            else
                            {
                                board[armyRow][armyCol] = 'X';
                                printLossingMessage(armyRow, armyCol);
                                break;
                            }

                        }
                        else if (board[armyRow + 1][armyCol] == 'M') // Win condition
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            board[armyRow + 1][armyCol] = '-';
                            printWinningMessage(health);
                            break;
                        }
                        else if (board[armyRow + 1][armyCol] == '-') // No obstacles '-'
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            armyRow++;
                            board[armyRow][armyCol] = 'A';
                        }
                    }
                    else // If outside the board remove health only
                    {
                        health--;
                    }
                }
                else if (direction == "left")
                {
                    if (ValidCordinates(armyRow, armyCol - 1, board)) // If board is valid
                    {
                        if (board[armyRow][armyCol - 1] == 'O') // If next is enemy
                        {
                            if (health >= 3)
                            {
                                health -= 2;
                                board[armyRow][armyCol] = '-';
                                armyCol--;
                                board[armyRow][armyCol] = 'A';
                            }
                            else
                            {
                                board[armyRow][armyCol] = 'X';
                                printLossingMessage(armyRow, armyCol);
                                break;
                            }

                        }
                        else if (board[armyRow][armyCol - 1] == 'M') // Win condition
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            board[armyRow][armyCol - 1] = '-';
                            printWinningMessage(health);
                            break;
                        }
                        else if (board[armyRow][armyCol - 1] == '-') // No obstacles '-'
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            armyCol--;
                            board[armyRow][armyCol] = 'A';
                        }
                    }
                    else // If outside the board remove health only
                    {
                        health--;
                    }
                }
                else if (direction == "right")
                {
                    if (ValidCordinates(armyRow, armyCol + 1, board)) // If board is valid
                    {
                        if (board[armyRow][armyCol + 1] == 'O') // If next is enemy
                        {
                            if (health >= 3)
                            {
                                health -= 2;
                                board[armyRow][armyCol] = '-';
                                armyCol++;
                                board[armyRow][armyCol] = 'A';
                            }
                            else
                            {
                                board[armyRow][armyCol] = 'X';
                                printLossingMessage(armyRow, armyCol);
                                break;
                            }

                        }
                        else if (board[armyRow][armyCol + 1] == 'M') // Win condition
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            board[armyRow][armyCol + 1] = '-';
                            printWinningMessage(health);
                            break;
                        }
                        else if (board[armyRow][armyCol + 1] == '-') // No obstacles '-'
                        {
                            health--;
                            board[armyRow][armyCol] = '-';
                            armyCol++;
                            board[armyRow][armyCol] = 'A';
                        }
                    }
                    else // If outside the board remove health only
                    {
                        health--;
                    }
                }
                if (health <= 0)
                {
                    printLossingMessage(armyRow, armyCol);
                    break;
                }
                PrintJaggedArray(board);
                Console.WriteLine(health);

            }
            Console.WriteLine();
            Console.WriteLine();
            PrintJaggedArray(board);
        }
            
        
            static bool ValidCordinates(int row, int col, char[][] board)
            {
                if (row < 0 || row > board.Length - 1)
                {
                    return false;
                }
                if (col < 0 || col > board[row].Length - 1)
                {
                    return false;
                }
                return true;
            }
           
        

        static void printLossingMessage(int row,int col)
        {
            Console.WriteLine($"The army was defeated at {row};{col}.");
        }
        static void printWinningMessage(int armor)
        {
            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
        }
        static (int, int) FindTheTroop(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'A')
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1);
        }
        public  static void PrintJaggedArray(char[][] board)
        {
            foreach (char[] row in board)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void ReadJaggedArray(char[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
            }
        }
    }
}

    
