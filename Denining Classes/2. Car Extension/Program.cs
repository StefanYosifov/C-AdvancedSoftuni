using System;

namespace _2._Car_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car=new Car();
            car.Make = "BMW";
            car.Model = "X6";
            car.Year = 2022;
            car.FuelQuantity = 50;
            car.FuelConsumption = 0.07;
            car.Drive(51);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
