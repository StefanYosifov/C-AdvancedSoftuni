using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowColArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = rowColArr[0];
            int col = rowColArr[1];

            int[,] matrix = new int[row, col];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < inputArr.Length; j++)
                {
                    matrix[i, j] = inputArr[j];
                }
            }


            int bigggestSum = 0;

            for(int i=0;i<matrix.GetLength(0)-3; i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1) - 3; j++)
                {
                    
                    for(int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            sum += matrix[i + k, j+l];
                        }
                    }
                    if(sum> bigggestSum)
                    {
                        bigggestSum = sum;
                    }
                }
            }
            Console.WriteLine(bigggestSum);


        }
    }
}
