using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield()
        {
            Drone = new List<Drone>();
        }

        public Airfield(string name, int capacity, double landingStrip)
        {

            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drone = new List<Drone>();
        }

        private List<Drone> Drone { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public double LandingStrip { get; set; }

        public int Count => this.Drone.Count;


        public string AddDrone(Drone newDrone)
        {
            if (string.IsNullOrEmpty(newDrone.Name) || string.IsNullOrEmpty(newDrone.Brand) || newDrone.Range < 5 || newDrone.Range > 15)
            {
                return "Invalid drone.";
            }
            if (Drone.Count >= this.Capacity)
            {
                return "Airfield is full.";
            }
            this.Drone.Add(newDrone);
            return $"Successfully added {newDrone.Name} to the airfield.";
        }


        public bool RemoveDrone(string name)
        {
            var newDrone = Drone.FirstOrDefault(x => x.Name == name);
            return Drone.Remove(newDrone);
        }

        public int RemoveDroneByBrand(string brand)
        {
            int count = Drone.RemoveAll(x => x.Brand == brand);
            return count;
        }

        public Drone FlyDrone(string name)
        {
            Drone findDrone = Drone.FirstOrDefault(x => x.Name == name);
            if (findDrone == null)
            {
                return null;
            }
            findDrone.Availabe = false;
            return findDrone;
        }

        public List<Drone> FlyDronesByRange(int Range)
        {
            List<Drone> newList = Drone.Where(x => x.Range>=Range).ToList();
            foreach(var drone in newList)
            {
                drone.Availabe = false;
            }
            return newList;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Drones available at {this.Name}:");
            sb.AppendLine($"{string.Join(Environment.NewLine, Drone)}");

            return sb.ToString().Trim();
        }

    }
}
