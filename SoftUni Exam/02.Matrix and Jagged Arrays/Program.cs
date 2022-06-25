using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Matrix_and_Jagged_Arrays
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
            (playerRow, playerCol) = FindVanko(matrix);

            string direction = Console.ReadLine();
            int hitRods = 0;
            int counter = 1;
            bool print= true;
            while(direction != "End")
            {
                if (direction == "up")
                {
                    if (HasValidCordinates(playerRow - 1, playerCol, matrix))
                    {
                        char getCurrentChar=matrix[playerRow, playerCol];
                        if (matrix[playerRow-1,playerCol]=='R') // Rod
                        {
                            hitRods++;
                            Console.WriteLine("Vanko hit a rod!");
                            
                        }
                        else if(matrix[playerRow - 1, playerCol] == 'C') // Cable
                        {
                            counter++;
                            print = false;
                            matrix[playerRow, playerCol] = '*';
                            playerRow--;
                            matrix[playerRow, playerCol]='E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {counter} hole(s).");
                            PrintMatrix(matrix);
                            return;
                        }
                        else if(matrix[playerRow - 1, playerCol] == '*')// Previous location
                        {
                            matrix[playerRow, playerCol] = '*';
                            playerRow--;
                            matrix[playerRow, playerCol] = 'V';
                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                        }
                        else // Dash
                        {
                            counter++;
                            matrix[playerRow, playerCol] = '*';
                            playerRow--;
                            matrix[playerRow, playerCol] = 'V';
                        }
                    }
                    
                }
                else if (direction == "down")
                {
                    if (HasValidCordinates(playerRow + 1, playerCol, matrix))
                    {
                        char getCurrentChar = matrix[playerRow, playerCol];
                        if (matrix[playerRow + 1, playerCol] == 'R') // Rod
                        {
                            hitRods++;
                            Console.WriteLine("Vanko hit a rod!");
                         
                        }
                        else if (matrix[playerRow + 1, playerCol] == 'C') // Cable
                        {
                            counter++;
                            print = false;
                            matrix[playerRow, playerCol] = '*';
                            playerRow++;
                            matrix[playerRow, playerCol] = 'E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {HolesMade(matrix)} hole(s).");
                            PrintMatrix(matrix);
                            return;
                        }
                        else if (matrix[playerRow + 1, playerCol] == '*')// Previous location
                        {
                            matrix[playerRow, playerCol] = '*';
                            playerRow++;
                            matrix[playerRow, playerCol] = 'V';
                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                        }
                        else // Dash
                        {
                            counter++;
                            matrix[playerRow, playerCol] = '*';
                            playerRow++;
                            matrix[playerRow, playerCol] = 'V';
                        }
                    }
                    
                }
                else if (direction == "left")
                {
                    if (HasValidCordinates(playerRow, playerCol-1, matrix))
                    {
                        char getCurrentChar = matrix[playerRow, playerCol];
                        if (matrix[playerRow, playerCol-1] == 'R') // Rod
                        {
                            hitRods++;
                            Console.WriteLine("Vanko hit a rod!");
                           
                        }
                        else if (matrix[playerRow, playerCol-1] == 'C') // Cable
                        {
                            counter++;
                            print = false;
                            matrix[playerRow, playerCol] = '*';
                            playerCol--;
                            matrix[playerRow, playerCol] = 'E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {HolesMade(matrix)} hole(s).");
                            PrintMatrix(matrix);
                            return;
                        }
                        else if (matrix[playerRow, playerCol-1] == '*')// Previous location
                        {
                            matrix[playerRow, playerCol] = '*';
                            playerCol--;
                            matrix[playerRow, playerCol] = 'V';
                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                       
                        }
                        else // Dash
                        {
                            counter++;
                            matrix[playerRow, playerCol] = '*';
                            playerCol--;
                            matrix[playerRow, playerCol] = 'V';
                        }
                    }
                    
                }
                else if (direction == "right")
                {
                    if (HasValidCordinates(playerRow, playerCol + 1, matrix))
                    {
                        char getCurrentChar = matrix[playerRow, playerCol];
                        if (matrix[playerRow, playerCol + 1] == 'R') // Rod
                        {
                            hitRods++;
                            Console.WriteLine("Vanko hit a rod!");
                           
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'C') // Cable
                        {
                            counter++;
                            print = false;
                            matrix[playerRow, playerCol] = '*';
                            playerCol++;
                            matrix[playerRow, playerCol] = 'E';
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {HolesMade(matrix)} hole(s).");
                            PrintMatrix(matrix);
                            return;
                        }
                        else if (matrix[playerRow, playerCol + 1] == '*')// Previous location
                        {
                            matrix[playerRow, playerCol] = '*';
                            playerCol++;
                            matrix[playerRow, playerCol] = 'V';
                            Console.WriteLine($"The wall is already destroyed at position [{playerRow}, {playerCol}]!");
                            
                        }
                        else // Dash
                        {
                            counter++;
                            matrix[playerRow, playerCol] = '*';
                            playerCol++;
                            matrix[playerRow, playerCol] = 'V';
                        }
                    }
                }
                direction=Console.ReadLine();
            }
            if (!print)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {counter} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {counter} hole(s) and he hit only {hitRods} rod(s).");
            }
            PrintMatrix(matrix);
        }

        public static int HolesMade(char[,] matrix)
        {
            int holes = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '*' || matrix[i,j]=='E')
                    {
                        holes++;
                    }
                }
            }
            return holes;
        }

        public static (int,int) FindVanko(char[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'V')
                    {
                        return (i,j);
                    }
                }
            }
            return (-1, -1);
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] inputArr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputArr[j];
                }
            }
        }

        public static bool HasValidCordinates(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


    }  
}
