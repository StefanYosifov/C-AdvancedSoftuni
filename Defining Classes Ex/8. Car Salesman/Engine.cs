using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Car_Salesman
{
    public class Engine
    {
        public Engine()
        {

        }
        public Engine(string model,int horsepower)
        {
            this.Model = model;
            this.HorsePower = horsepower;
        }

        public Engine(string model, int horsepower, int displacement)
        {
            this.Model = model;
            this.HorsePower = horsepower;
            this.Displacement = displacement;
        }

        public Engine(string model, int horsepower, string efficinecy)
        {
            this.Model = model;
            this.HorsePower = horsepower;
            this.Efficiency = efficinecy;
        }
        public Engine(string model, int horsepower, int displacement,string efficinecy)
        {
            this.Model=model;
            this.HorsePower=horsepower;
            this.Displacement = displacement;
            this.Efficiency = efficinecy;
        }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
