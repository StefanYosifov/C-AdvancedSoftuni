using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            List<Car> cars= new List<Car>();
            Car car = new Car();
            for(int i = 0; i < loops; i++)
            {
                string[] information=Console.ReadLine().Split(' ',6).ToArray();
                var Engine=new Engine();
                var Cargo = new Cargo();
                var Tires = new List<Tire>();
                string Model=information[0];
                Engine.Speed = int.Parse(information[1]);
                Engine.HorsePower = int.Parse(information[2]);
                Cargo.Weight = int.Parse(information[3]);
                Cargo.Type=information[4];
                string[] TiresAndPressure=information[5].Split(' ').ToArray();
                for(int j = 0; j < TiresAndPressure.Length; j += 2)
                {
                    Tire Tire = new Tire();
                    Tire.Pressure = double.Parse(TiresAndPressure[j]);
                    Tire.Age = int.Parse(TiresAndPressure[j + 1]);
                    Tires.Add(Tire);

                }
                car = new Car(Model, Engine, Cargo, Tires.ToArray());
                cars.Add(car);
            }

            string action=Console.ReadLine();
            if (action == "fragile")
            {
                car.PrintFragile(cars);
                
            }
            else if(action == "flammable")
            {
                car.PrintFlammable(cars);
            }

        }
    }
}
