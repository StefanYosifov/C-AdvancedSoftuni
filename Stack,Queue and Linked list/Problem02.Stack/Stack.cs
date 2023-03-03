namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IAbstractStack<T>
    {
        private class Node
        {
            public Node(T value)
            {
                this.Element = value;
            }

            public Node(T value,Node next)
            {
                this.Element = value;
                this.Next = next;
            }


            public T Element { get; set; }

            public Node Next { get; set; }

        }



        private Node top;

        public int Count { get; set; } = 0;

        public void Push(T item)
        {
            var node = new Node(item, this.top);
            this.top = node;
            this.Count++;
        }

        // 1 2
        // 1 2-3


        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var oldTop = this.top;
            this.top = oldTop.Next;
            this.Count--;
            return oldTop.Element;

        }

        // 1 2 3 4 5
        // 1 2 3 4 5

        public T Peek()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException();
            }
            return this.top.Element;
        }

        public bool Contains(T item)
        {
            foreach(var node in this)
            {
                if (node.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.top;
            while (node != null)
            {
                yield return node.Element;
                node= node.Next;
            }
        }

        //1 2 3 4 5
        //  

        IEnumerator IEnumerable.GetEnumerator()=>this.GetEnumerator();
    }
}