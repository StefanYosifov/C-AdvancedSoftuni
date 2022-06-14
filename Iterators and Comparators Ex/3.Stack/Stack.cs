using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3.Stack
{
    public class Stack<T>:IEnumerable<T>
    {
        public Stack(params T[] data)
        {
            collection = new List<T>(data);
            
            
        }


        private List<T> collection;
        

        public void Push(params T[] input)
        {
            foreach(var element in input)
            {
                collection.Insert(collection.Capacity, element);
            }
        }

        public T Pop()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            T element = collection[collection.Count - 1];
            collection.RemoveAt(collection.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i=collection.Count-1; i>=0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
    }
}
