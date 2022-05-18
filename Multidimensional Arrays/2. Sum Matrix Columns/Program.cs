using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix=new int[rowsAndCols[0],rowsAndCols[1]];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbersToAdd = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for(int j=0; j < numbersToAdd.Length; j++)
                {
                    
                    matrix[i,j] = numbersToAdd[j];
                }
            }

            for(int j=0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;
                for(int i=0; i < matrix.GetLength(0); i++)
                {
                    sum+=matrix[i,j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
