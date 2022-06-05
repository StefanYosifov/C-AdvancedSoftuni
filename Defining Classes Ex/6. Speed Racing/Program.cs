using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int loops=int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for(int i=0;i<loops;i++)
            {
                string[] information=Console.ReadLine().Split(' ').ToArray();
                string name=information[0];
                if (cars.Select(x => x.Model).Contains(name))
                {
                    continue;
                }
                double fuelAmount = double.Parse(information[1]);
                double distanceTravelled=double.Parse(information[2]);
                Car car = new Car(name,fuelAmount,distanceTravelled);
                cars.Add(car);
            }

            string tokens=Console.ReadLine();
            while (tokens != "End")
            {
                string[] information = Console.ReadLine().Split(' ').ToArray();
                string actionOrModel=information[0];
                if(actionOrModel == "Drive")
                {
                    string model=information[1];
                    double kilometres=double.Parse(information[2]);
                    Car carDrive=cars.First(x => x.Model == model);
                    carDrive.Drive(kilometres);
                }
                

                tokens=Console.ReadLine();
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
