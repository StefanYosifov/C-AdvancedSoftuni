using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] input=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           int[,] matrix = new int[input[0], input[1]];
           for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numberToAdd =Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j=0; j < numberToAdd.Length; j++)
                {
                    matrix[i,j] = numberToAdd[j];
                }
            }

            int sum = 0;
            foreach(var element in matrix)
            {
                sum += element;
            }
            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);
            Console.WriteLine(sum);

        }
    }
}
