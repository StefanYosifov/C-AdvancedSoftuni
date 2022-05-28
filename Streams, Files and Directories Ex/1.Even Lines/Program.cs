using System;
using System.IO;
using System.Linq;

namespace _1.Even_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Stefan\Desktop\text.txt";
            int counter = -1;
            using(StreamReader reader=new StreamReader(filePath))
            {
                counter++;
                string line=reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                    line = Replace(line);
                    line = Reverse(line);
                    line = reader.ReadLine();
                    
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }

        }
        static string Reverse(string line)
        {
           return string.Join(" ", line.Split().Reverse());
        }
        static string Replace(string line)
        {
            return line.Replace('-', '@').Replace(',','@').Replace('.','@').Replace('!','@').Replace('?','@');
        }
       
    }
}
