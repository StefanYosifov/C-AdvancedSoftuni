namespace Problem03.Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyQueue<T> : IAbstractQueue<T>
    {
        private class Node
        {
            public Node(T element)
            {
                this.Element = element;
            }

            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public T Element { get; set; }

            public Node Next { get; set; }
        }

        private Node head;

        public int Count { get; set; } = 0;

        public void Enqueue(T item)
        {
            var node = new Node(item);
            if (this.Count == 0)
            {
                this.head = node;
            }
            else
            {
                var iterating = this.head;
                while (iterating.Next != null)
                {
                    iterating = iterating.Next;
                }
                iterating.Next = node;
            }
            this.Count++;

        }

        // 1 2 3 4 5
        // 1 2 3 4 5 6 head-1 tail-6


        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var oldNode = this.head;
            var newTop = oldNode.Next;
            this.head = newTop;
            this.Count--;
            return oldNode.Element;
        }

        // 1 2 3 4 5
        // 2 3 4 5

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return this.head.Element;
        }

        public bool Contains(T item)
        {
            foreach(var element in this)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;
            while (node != null)
            {
                yield return node.Element;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=>this.GetEnumerator();  
    }
}