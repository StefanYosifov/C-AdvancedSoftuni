using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            collection = new List<Car>();
        }

        List<Car> collection { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        public int Count => collection.Count;

        public void Add(Car car)
        {
            if(car.HorsePower <= MaxHorsePower && collection.Any(x=>x.LicensePlate==car.LicensePlate)==false && collection.Count < this.Capacity)
            {
                collection.Add(car);
            }

        }

        public bool Remove(string licensePlate)
        {
            if (this.collection.Any(x => x.LicensePlate == licensePlate))
            {
                this.collection.Remove(collection.First(x => x.LicensePlate == licensePlate));
                this.Capacity++;
                return true;
            }
            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
       
            var findCar = this.collection.FirstOrDefault(x => x.LicensePlate == licensePlate);
            return findCar;
        }

        public Car GetMostPowerfulCar()
        {
            return this.collection.OrderBy(x=>x.HorsePower).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in this.collection)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
