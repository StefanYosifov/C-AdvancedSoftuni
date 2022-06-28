using System;
using System.Collections.Generic;
using System.Linq;

namespace Easy_does_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&').ToList();
            string[] action = Console.ReadLine().Split(" | ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (action[0] != "Done")
            {
                if (action[0] == "Add Book")
                {
                    string bookToAdd = action[1];
                    if (books.Contains(bookToAdd))
                    {

                    }
                    else
                    {
                        books.Insert(0, bookToAdd);
                    }
                }
                else if (action[0] == "Take Book")
                {
                    string bookToTake = action[1];
                    if (books.Contains(bookToTake))
                    {
                        books.Remove(bookToTake);
                    }
                }
                else if (action[0] == "Swap Books")
                {
                    string firstBook = action[1];
                    int indexOfFirstBook = books.IndexOf(firstBook);

                    string secondBook = action[2];
                    int indexOfSecondBook = books.IndexOf(secondBook);
                    books = Swap(books, indexOfFirstBook, indexOfSecondBook).ToList();
                }
                else if (action[0] == "Insert Book")
                {
                    string bookToAdd = action[1];
                    if (!books.Contains(bookToAdd))
                    {
                        books.Add(bookToAdd);
                    }
                }
                else if (action[0]=="Check Book")
                {
                    int indexToCheck = int.Parse(action[1]);
                    if (HasValidIndex(books, indexToCheck))
                    {
                        Console.WriteLine($"{books[indexToCheck]}");
                    }
                }
                action = Console.ReadLine().Split(" | ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine(string.Join(", ",books));
        }
        public static bool HasValidIndex(List<string> list,int index)
        {
            return index>=0 && index<list.Count;
        }
        public static IList<T> Swap<T>(IList<T> list, int indexA, int indexB)
        {
            (list[indexA], list[indexB]) = (list[indexB], list[indexA]);
            return list;
        }
    }
}
