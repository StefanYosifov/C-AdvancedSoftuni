using System;
using System.IO;

namespace _1._Odd_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            using (reader)
            {
                
                var writer = new StreamWriter("input.txt");
                using (writer)
                {
                    int lineNumber = 0;
                    while (true)
                    {
                        lineNumber++;
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (lineNumber % 2 == 1)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}
