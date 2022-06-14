using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1._ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {

        public ListyIterator(params T[] data)
        {
            collection = new List<T>(data);
            currentIndex = 0;
        }

        private List<T> collection;

        private int currentIndex;

        public bool HasNext()
        {
            return currentIndex < collection.Count - 1;
        }

        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currentIndex++;
            }
            return canMove;
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("Invalid operation");
            }
            Console.WriteLine($"{collection[currentIndex]}");
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ",collection));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T element in collection)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
        
    }
}
