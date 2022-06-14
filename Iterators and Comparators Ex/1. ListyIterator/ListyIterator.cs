using System;
using System.Collections.Generic;
using System.Text;

namespace _1._ListyIterator
{
    public class ListyIterator<T>
    {

        public ListyIterator(params T[] data)
        {
            collection = new List<T>();
            currentIndex = 0;
        }

        private List<T> collection;

        private int currentIndex;

        public bool HasNext()
        {
            return currentIndex < collection.Count-1;
        }

        public bool Move()
        {
            bool canMove=HasNext();
            if (canMove)
            {
                currentIndex++;
            }
            return canMove;
        }

        public void Print()
        {
            if(collection.Count == 0)
            {
                throw new ArgumentException("Invalid operation");
            }
            Console.WriteLine($"{collection[currentIndex]}");
        }

    }
}
