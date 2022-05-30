using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> VTA = (a) => (a * 1.2);
            double[] nums=Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            double[] numsWithVta=nums.Select(VTA).ToArray();
            foreach(var element in numsWithVta)
            {
                Console.WriteLine($"{element:F2} ");
            }
        }
    }
}
