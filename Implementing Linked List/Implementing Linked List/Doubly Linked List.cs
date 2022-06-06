using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Linked_List
{
    public class Doubly_Linked_List
    {

        public int Count { get; private set; }

        public LinkedListNode Head { get; private set; }

        public LinkedListNode Tail { get; private set; }

        public bool IsEmpty =>this.Count == 0;
        public void AddHead(int value)
        {
            if (IsEmpty)
            {
                var newNode = new LinkedListNode(value);

            }
            else
            {
                var previousHead=Head;
                var newNode=new LinkedListNode(value);
                previousHead.Previous = newNode;
                newNode.Next = previousHead;
                this.Head = newNode;
            }
            Count++;
        }

        public void AddTail(int value)
        {
            if (this.IsEmpty)
            {
                Head=Tail=new LinkedListNode(value);
            }
            else
            {
                var previousTail=Tail;
                var newNode=new LinkedListNode(value);
                newNode.Previous=previousTail;
                previousTail.Next=newNode;
            }
        }

        public void RemoveHead()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException($"The linked list is empty");
            }
            else
            {
                var removeHead = this.Head;
                var removedHeadValue=removeHead.Value;

                var nextHead = removeHead.Next;
                if (nextHead == null)
                {
                    this.Head = this.Tail=null;
                }
                else
                {
                    nextHead.Previous=null;
                    removeHead.Next=null;
                    this.Head=nextHead;
                }
                this.Count--;
            }
            
        }

        public void RemoveTail()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException($"The linked list is empty");
            }
            var removeTail = this.Tail;
            var removedTailValue=removeTail.Value;
            var nextTail = removeTail.Previous;
            if (nextTail == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextTail.Next=null;
                removeTail.Previous=null;

                this.Tail=nextTail;
            }
            this.Count--;
        }

        public void ForEach(Action<int> action)
        {
            var currentNode=this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode=currentNode.Next;
            }
        }

        public List<int> ToList()
        {
            var list=new List<int>();
            list.ForEach(n=>list.Add(n));
            return list;
        }
        public class LinkedListNode
        {
            public LinkedListNode(int value)
            {
                this.Value = value;
            }

            public int Value { get; set; }

            public LinkedListNode Next { get; set; }    

            public LinkedListNode Previous { get; set; }


        }

    }
}
