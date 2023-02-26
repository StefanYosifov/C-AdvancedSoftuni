namespace Creating_a_List
{
    using System.Collections;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> list=new List<int>();

            MyList<int> myList = new MyList<int>();


            list.Remove(1);

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            myList.Remove(3);
            myList.Clear();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            myList.Add(10);
            myList.Add(15);
            myList.Insert(0, 5);
            myList.Insert(2, 1);
            myList.Insert(4, 2);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");
            myList.RemoveAt(3);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

        }
    }
}