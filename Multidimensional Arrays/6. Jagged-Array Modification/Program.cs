using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount=int.Parse(Console.ReadLine());
            int[][] jaggedArray=new int[rowsCount][];
            for(int i=0; i<jaggedArray.Length; i++)
            {
                jaggedArray[i]=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            }

            string command=Console.ReadLine();
            while (command != "END")
            {
                string[] commandArr=command.Split(' ');
                if (commandArr[0] == "Add")
                {
                    int row = int.Parse(commandArr[1]);
                    int col = int.Parse(commandArr[2]);
                    int value=int.Parse(commandArr[3]);
                    if(row>=0 && row<jaggedArray.Length && col>=0 && col <= jaggedArray.Length)
                    {
                        jaggedArray[row][col]+=value;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid coordinates");
                    }
                }
                else if (commandArr[0] == "Subtract")
                {
                    int row = int.Parse(commandArr[1]);
                    int col = int.Parse(commandArr[2]);
                    int value = int.Parse(commandArr[3]);
                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col <= jaggedArray.Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }

            foreach(var rows in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",rows));
            }

        }
    }
}
