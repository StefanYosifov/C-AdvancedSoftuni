using System;
using System.IO;

namespace Streams__Files_and_Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineNum = 0;
            StreamReader reader = new StreamReader("");

            while(true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                lineNum++;
                Console.WriteLine($"{lineNum}. {line}");
            }
            
        }
    }
}
