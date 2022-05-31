using System;
using System.Linq;

namespace Functional_Programming_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> namesWithDot = name => name + ".";
            //string name=Console.ReadLine();
            //Console.WriteLine(namesWithDot(name));


            Func<string,string> namesArrWithSir=name=>"Sir " + name;
            String[] names = Console.ReadLine().Split(' ').ToArray();
            names.ToList().ForEach(name=>Console.WriteLine(namesArrWithSir(name)));
        }
    }
}
