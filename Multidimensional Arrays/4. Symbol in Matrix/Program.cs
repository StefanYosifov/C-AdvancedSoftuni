using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for(int j=0; j < arr.Length; j++)
                {
                    matrix[i, j] = arr[j].ToString();
                }
            }

            char symbolToLookFor = char.Parse(Console.ReadLine());
            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == symbolToLookFor.ToString())
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbolToLookFor} does not occur in the matrix");
            
        }
    }
}
