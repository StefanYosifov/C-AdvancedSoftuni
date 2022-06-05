using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._Raw_Data
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string model,Engine engine,Cargo cargo,Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = tires;
        }

        private Tire[] tires;
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires
        {
            get { return tires; }

            set
            {
                if (value.Length == 4)
                {
                    tires = value;
                }
            }

        }


        public void PrintFragile(List<Car> list)
        {
            var newList = list.Where(x => x.Cargo.Type == "fragile");
            foreach(Car car in newList)
            {
                foreach(var car1 in car.Tires)
                {
                    if (car1.Pressure < 1)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{car.Model}");
            }
        }

        public void PrintFlammable(List<Car> cars)
        {
            var newList = cars.Where(x=>x.Cargo.Type== "flammable").Where(y=>y.Engine.HorsePower>250);
            foreach(var car in newList)
            {
                Console.WriteLine($"{car.Model}");
            }
        }

    }
}
