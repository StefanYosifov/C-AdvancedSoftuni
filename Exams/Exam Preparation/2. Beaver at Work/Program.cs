using System;
using System.Linq;

namespace _2._Beaver_at_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadMatrix();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;

                }
                if (command == "up")
                {

                }
                if (command == "down")
                {

                }
                if (command == "right")
                {

                }
                if (command == "left")
                {

                }
            }

        }

        private static (int x,int y) FindBeaverLocation(char[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] == 'B')
                    {
                        return (i, j);
                    }
                }
            }
            throw new Exception("Outside");
        }

        private static void ReadMatrix()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var rows = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    char currentChar = rows[j];
                    matrix[i, j] = currentChar;
                }
            }
        }
    }
}
