using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Queue_and_Stack
{
    public class MyList
    {

        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data=new int[capacity];
        }

        private int[] data;
        private int capacity;

        public int Count { get;private set; }

        public void Add(int value)
        {
            if(this.data.Length ==capacity)
            {

            }

            data[this.capacity] = value;
            this.Count++;
        }

        private void Resize()
        {
            var newCapacity=this.data.Length*2;
            var newData=new int[newCapacity];
            for(int i = 0; i < this.data.Length; i++)
            {
                newData[i]=this.data[i];
            }
            this.data=newData;
        }


    }
}
