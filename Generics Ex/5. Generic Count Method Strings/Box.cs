using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Box
{
    public class Box<T> : IComparable<T> where T: IComparable<T>
    {

        public Box(T element)
        {

        }

        public Box(List<T> elementsList)
        {
            this.Elements = elementsList;
        }

        public int CountOfGreaterElements<T>(List<T> list, T readLine) where T : IComparable =>
            list.Count(word => word.CompareTo(readLine)> 0);

        public List<T> Elements { get; }
        public T Element { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }


            return sb.ToString().Trim();
        }

        public void Swap(List<T> list, int firstIndex, int secondIndex)
        {
            T firstEelement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstEelement;
        }

        public int CompareTo(T other)
        => Element.CompareTo(other);    
    }
}
