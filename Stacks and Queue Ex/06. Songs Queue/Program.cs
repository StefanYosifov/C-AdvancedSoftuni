using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] ArrayOfSongs = Console.ReadLine().Split(", ").ToArray();
            var songs = new Queue<string>(ArrayOfSongs);


            while(true)
            {
                string[] receiveCommand = Console.ReadLine().Split(' ',1).ToArray();
                string command= receiveCommand[0];

                if (command == "Play")
                {
                    if (songs.Count == 0)
                    {
                        Console.WriteLine($"No more songs");
                        break;
                    }
                    songs.Dequeue();
                }

                if (command.StartsWith("Add"))
                {
                    string song=receiveCommand[1];
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }

                if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }


            }

        }
    }
}
