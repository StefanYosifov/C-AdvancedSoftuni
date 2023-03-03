namespace Creating_a_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MyList<T> : IList<T>
    {

        private const int InitialCapacity = 4;
        private T[] elements;
        private int size;
        private int capacity;


        public MyList()
        {
            this.elements = new T[InitialCapacity];
            this.capacity = InitialCapacity;
            this.size = 0;
        }

        public T this[int index] 
        { 
            get 
            {
                if (ValidateIndex(index) == true) 
                { 
                    return elements[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set 
            {
                if (ValidateIndex(index) == true)
                {
                    elements[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            } 
        
        }
           
        

        public int Count => size;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T element)
        {
            if (this.Count == this.capacity)
            {
                this.elements = this.DoubleCapacity();
            }


            this.elements[size]=element;
            this.size++;
        }

        public void Clear()
        {
            this.capacity = InitialCapacity;
            this.size = 0;
            this.elements = new T[InitialCapacity];
        }

        public bool Contains(T item)
        {
            for(int i = 0; i < this.elements.Length; i++)
            {
                T currentElement=this.elements[i];
                if(object.Equals(currentElement, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < this.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        public int IndexOf(T item)
        {
            
            for(int i = 0; i < this.size; i++)
            {
                T currentElement = this.elements[i];
                if (object.Equals(currentElement, item))
                {
                    return i;
                }
            }
            return -1;
        }



        public void Insert(int index, T item)
        {
            if (index > this.size)
            {
                throw new IndexOutOfRangeException();
            }

            this.size++;
            ShiftRight(index);
            this.elements[index] = item;
        }

       

     


        public bool Remove(T item)
        {
            for(int i = 0; i < this.Count; i++)
            {
                T currentElement = this.elements[i];
                if (object.Equals(currentElement, item))
                {
                    ShiftLeftElements(i);
                    return true;
                }
            }
            return false;
        }


        public void RemoveAt(int index)
        {
            ShiftLeftElements(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        private void ShiftRight(int index)
        {
            if (this.Count == this.capacity)
            {
                this.elements = this.DoubleCapacity();
            }


            for (int i = this.size; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
        }

        private T[] DoubleCapacity()
        {
            T[] newArray = new T[this.capacity * 2];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[i];
            }
            this.capacity *= 2;
            return newArray;
        }

        private void ShiftLeftElements(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.size--;
        }


        private T[] HalveCapacity()
        {
            T[] newArr = new T[this.capacity/2];
            for(int i = 0; i < this.Count; i++)
            {
                newArr[i] = this.elements[i];
            }
            return newArr;
        }

        private bool ValidateIndex(int index)
        {
            if(index>this.capacity || index < 0)
            {
                return false;
            }
            return true;
        }

    }
}
