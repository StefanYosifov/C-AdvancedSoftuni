using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car()
        {
            cars=new List<Car>();
        }
        public Car(string model,double fuelAmount,double fuelConsumptionPerKilometer,double travelledDistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = FuelConsumptionPerKilometer;
            this.TravelledDistance = travelledDistance;
        }
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        List<Car> cars;
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }


        public void Drive(double distance)
        {
            double neededLitres = distance * FuelConsumptionPerKilometer;


            if (distance >= neededLitres)
            {
                FuelAmount-=neededLitres;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

    }
}
