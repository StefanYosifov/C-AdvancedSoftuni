using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] matrix = new string[sizeOfMatrix[0], sizeOfMatrix[1]];

            for(int i=0; i<sizeOfMatrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j=0;j<input.Length; j++)
                {
                    matrix[i,j] = input[j];
                }
                
            }

            string command=Console.ReadLine();
            while(command != "END")
            {
                string[] commandArray=command.Split(' ');
                if (commandArray[0] == "swap")
                {
                    int firstRow = int.Parse(commandArray[1]);
                    int firstCol = int.Parse(commandArray[2]);
                    int secondRow = int.Parse(commandArray[3]);
                    int secondCol = int.Parse(commandArray[4]);
                    if(firstRow>matrix.GetLength(0) || firstRow<0 || secondRow>matrix.GetLength(0) || secondRow < 0)
                    {
                        Console.WriteLine($"Invalid input !");
                    }
                    else if(firstCol > matrix.GetLength(1) || firstCol < 0 || secondCol > matrix.GetLength(0) || secondCol < 0)
                    {
                        Console.WriteLine($"Invalid input !");
                    }
                    else if (commandArray.Length != 5)
                    {
                        Console.WriteLine($"Invalid input !");
                    }
                    else
                    {
                        string firstWord=matrix[firstCol,firstCol];
                        string secondWord=matrix[secondRow,secondCol];
                        string savingWord = firstWord;
                        for (int i = firstRow; i < 1; i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();

                        }
                     
                        matrix[firstCol, firstCol] = secondWord;
                        matrix[secondRow, secondCol] = savingWord;
                        for (int i = secondRow; i < 1; i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                       
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input !");
                }

                command = Console.ReadLine();
            }
        }
    }
}

