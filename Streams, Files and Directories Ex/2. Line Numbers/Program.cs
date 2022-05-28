using System;
using System.IO;
using System.Linq;

namespace _2._Line_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pathFile = @"C:\Users\Stefan\Desktop\SoftUniC#\input.txt";
            string outputFile = @"C:\Users\Stefan\Desktop\SoftUniC#\output.txt";
            string[] lines=File.ReadAllLines(pathFile);

            int count = 0;
            foreach (string line in lines)
            {
                count++;
                string modifiedLine = "Line" + " " + count + " " + line;
                int countLetters=line.Count(char.IsLetter);
                int countPunctuation=line.Count(char.IsPunctuation);
                Console.WriteLine(modifiedLine);
            }

        }
    }
}
