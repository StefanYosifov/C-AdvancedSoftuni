using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Car_Extension
{
    public class Car
    {
        public Car() : this("VW", "Golf", 2025)
        {

        }

        public Car(string make, string model, int year) : this(make, model, year, 200, 100)
        {

        }


        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine,Tire[] tires)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.
        }


        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

         
        public void Drive(double distance)
        {
            double consumption = this.FuelConsumption * distance;
            if (consumption <= fuelQuantity)
            {
                fuelQuantity = fuelQuantity - consumption;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            string returnMessage = $"Make {this.Make}\r\nModel: {this.Model}\r\nYear: {this.Year}\r\nFuel: {this.FuelQuantity:F2}";
            return returnMessage;
        }

    }
}
