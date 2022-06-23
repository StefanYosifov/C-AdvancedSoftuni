using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {

        public Parking(string type, int capacity)
        {
            data= new List<Car>();
            Type = type;
            Capacity = capacity;
        }

        private List<Car> data { get; set; }
        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public void Add(Car car) // -
        {
            if (data.Count < this.Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer,string model)  // -
        {
            foreach(var car in data)
            {
                if(car.Manufacturer==manufacturer && car.Model == model)
                {
                    return this.data.Remove(car);
                }
            }
            return false;
        }

        public Car GetLatestCar() // -
        {
            var latestestCar=data.OrderByDescending(x=>x.Year).FirstOrDefault();
            return latestestCar;
        }

        public Car GetCar(string manufacturer,string model) // -
        {
            var findTheCar = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            return findTheCar;
            
        }

        public string GetStatistics() // mby
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                sb.AppendLine($"{car}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
