using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;

        public int Count { get { return data.Count; } } 

        public Box()
        {
            this.data=new List<T>();
        }
        public void Add(T value)
        {
            this.data.Add(value);
        }

        public T Remove()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidCastException("The box is empty");
            }
            var lastElement=this.data[this.data.Count-1];
            this.data.RemoveAt(this.data.Count-1);
            return lastElement;
        }

    }
}
