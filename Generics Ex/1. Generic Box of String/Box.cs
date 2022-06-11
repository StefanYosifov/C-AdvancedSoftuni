using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box<T>
    {

        public Box(T element)
        {

        }

        public Box(List<T> elementsList)
        {
            this.Elements=elementsList;
        }
        public List<T> Elements { get;}
        public T Element { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }


            return sb.ToString().Trim();
        }

        public void Swap(List<T> list,int firstIndex, int secondIndex)
        {
            T firstEelement=list[firstIndex];
            list[firstIndex]=list[secondIndex];
            list[secondIndex]=firstEelement;
        }

    }
}
