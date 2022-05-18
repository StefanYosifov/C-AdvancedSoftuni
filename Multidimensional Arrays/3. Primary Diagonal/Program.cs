using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine()); 
            int[,] matrix = new int[size,size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbersToAdd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < numbersToAdd.Length; j++)
                {

                    matrix[i, j] = numbersToAdd[j];
                }
            }

            int sum = 0;
            for(int i=0;i< matrix.GetLength(0); i++)
            {
                for(int j=0; j< matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum+=matrix[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
