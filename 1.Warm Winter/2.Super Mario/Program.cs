using System;
using System.Linq;

namespace _2.Super_Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int castleSize = int.Parse(Console.ReadLine());
            string[,] matrix = new string[castleSize, castleSize];
            int MarioRow = 0;
            int MarioCol = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string inputArr = Console.ReadLine();
                for (int j = 0; j < inputArr.Length; j++)
                {
                    char currentChar = inputArr[j];
                    matrix[i, j] = currentChar.ToString();
                    
                }
            }

            (MarioRow,MarioCol)=MarioCordinates(matrix);
            PrintMatrixDebug(matrix);



            while (true)
            {
                string[] action = Console.ReadLine().Split(' ').ToArray();
                string direction = action[0];
                int enemyRow = int.Parse(action[1]);
                int enemyCol = int.Parse(action[2]);
                matrix[enemyRow, enemyCol] = "B";
                if (direction == "W")
                {
                    if (IsInRange(MarioRow - 1, MarioRow, matrix)) // If cordinate is valid
                    {
                        if (matrix[MarioRow - 1, MarioCol] == "B") // Enemy
                        {
                            if (health >= 3) // If mario has more health than the enemy
                            {
                                matrix[MarioRow, MarioCol] = "-";
                                MarioRow--;
                                matrix[MarioRow, MarioCol] = "M";
                                health -= 2;
                                Console.WriteLine($"Fighting B");
                            }
                            else // Mario Dies
                            {
                                matrix[MarioRow, MarioCol] = "X";
                                break;
                            }
                        }
                        else if(matrix[MarioRow - 1, MarioCol] == "P") // Princess
                        {
                            health--;
                            matrix[MarioRow, MarioCol] = "-";
                            matrix[MarioRow - 1, MarioCol] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                            return;
                        }
                        else if (matrix[MarioRow-1,MarioCol]=="-")
                        {
                            matrix[MarioRow, MarioCol] = "-";
                            MarioRow--;
                            matrix[MarioRow, MarioCol] = "M";
                            health--;
                            //Console.WriteLine($"Just move");
                        }
                    }
                    else // Invalid Cordinate
                    {
                        Console.WriteLine("Invalid cordinates");
                        health--;
                        
                    }
                }
                else if (direction == "S")
                {
                    if (IsInRange(MarioRow + 1, MarioRow, matrix)) // If cordinate is valid
                    {
                        if (matrix[MarioRow + 1, MarioCol] == "B") // Enemy
                        {
                            if (health >= 2) // If mario has more health than the enemy
                            {
                                matrix[MarioRow, MarioCol] = "-";
                                MarioRow++;
                                matrix[MarioRow, MarioCol] = "M";
                                health -= 2;
                                Console.WriteLine($"Fighting B");
                            }
                            else // Mario Dies
                            {
                                matrix[MarioRow, MarioCol] = "X";
                                break;
                            }
                        }
                        else if (matrix[MarioRow + 1, MarioCol] == "P") // Princess
                        {
                            health--;
                            matrix[MarioRow, MarioCol] = "-";
                            matrix[MarioRow + 1, MarioCol] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                            return;
                        }
                        else if (matrix[MarioRow + 1, MarioCol] == "-")
                        {
                            matrix[MarioRow, MarioCol] = "-";
                            MarioRow++;
                            matrix[MarioRow, MarioCol] = "M";
                            health--;
                            Console.WriteLine($"Just move");
                        }
                    }
                    else // Invalid Cordinate
                    {
                        Console.WriteLine("Invalid cordinates");
                        health--;

                    }
                }
                else if (direction == "A")
                {
                    if (IsInRange(MarioRow, MarioRow-1, matrix)) // If cordinate is valid
                    {
                        if (matrix[MarioRow, MarioCol-1] == "B") // Enemy
                        {
                            if (health >= 2) // If mario has more health than the enemy
                            {
                                matrix[MarioRow, MarioCol] = "-";
                                MarioCol--;
                                matrix[MarioRow, MarioCol] = "M";
                                health -= 2;
                                Console.WriteLine($"Fighting B");
                            }
                            else // Mario Dies
                            {
                                matrix[MarioRow, MarioCol] = "X";
                                break;
                            }
                        }
                        else if (matrix[MarioRow, MarioCol-1] == "P") // Princess
                        {
                            health--;
                            matrix[MarioRow, MarioCol] = "-";
                            matrix[MarioRow, MarioCol-1] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                            return;
                        }
                        else if (matrix[MarioRow , MarioCol-1] == "-")
                        {
                            matrix[MarioRow, MarioCol] = "-";
                            MarioCol--;
                            matrix[MarioRow, MarioCol] = "M";
                            health--;
                       
                        }
                    }
                    else // Invalid Cordinate
                    {
                       
                        health--;

                    }
                }
                else if (direction == "D")
                {
                    if (IsInRange(MarioRow, MarioRow + 1, matrix)) // If cordinate is valid
                    {
                        if (matrix[MarioRow, MarioCol + 1] == "B") // Enemy
                        {
                            if (health >= 2) // If mario has more health than the enemy
                            {
                                matrix[MarioRow, MarioCol] = "-";
                                MarioCol++;
                                matrix[MarioRow, MarioCol] = "M";
                                health -= 2;
                                //Console.WriteLine($"Fighting B");
                            }
                            else // Mario Dies
                            {
                                matrix[MarioRow, MarioCol] = "X";
                                break;
                            }
                        }
                        else if (matrix[MarioRow, MarioCol+1] == "P") // Princess
                        {
                            health--;
                            matrix[MarioRow, MarioCol] = "-";
                            matrix[MarioRow, MarioCol + 1] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                            return;
                        }
                        else if (matrix[MarioRow, MarioCol + 1] == "-")
                        {
                            matrix[MarioRow, MarioCol] = "-";
                            MarioCol++;
                            matrix[MarioRow, MarioCol] = "M";
                            health--;
                            //Console.WriteLine($"Just move");
                        }
                    }
                    else // Invalid Cordinate
                    {
                        Console.WriteLine("Invalid cordinates");
                        health--;

                    }
                }

                if (health <= 0)
                {
                    matrix[MarioRow, MarioCol] = "X";
                    break;
                }
                PrintMatrixDebug(matrix);
                Console.WriteLine(health);
            }

        }

        static public (int,int) MarioCordinates(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == "M")
                    {
                        return (i,j);
                    }
                }
                Console.WriteLine();
            }
            return (-1, -1);
        }

        private static void ReadMatrix(string[,] matrix)
        {

        }
    
       static public bool IsInRange(int row, int col, string[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
            col >= 0 && col < matrix.GetLength(1);

        }
        private static void PrintMatrix(string[,] matrix)
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

        private static void PrintMatrixDebug(string[,] matrix)
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
    }
}
