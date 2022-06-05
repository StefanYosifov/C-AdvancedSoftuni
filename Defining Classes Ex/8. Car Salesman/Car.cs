using System;
using System.Collections.Generic;
using System.Text;

namespace _8._Car_Salesman
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string model,Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine,int weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
        }


        public Car(string model,Engine engine,int weight,string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;


        }

        public string Model { get; set; }

        public  Engine Engine { get; set; }

        public int Weight { get; set; } 

        public string Color { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"   Power: {  this.Engine.HorsePower}");
            if (this.Engine.Displacement == 0)
            {
                sb.AppendLine("   Displacement: n/a");
            }

            else
            {
                sb.AppendLine($"   Displacement: {this.Engine.Displacement}");
            }

            sb.AppendLine($"   Efficiency: {this.Engine.Efficiency}");
            if (this.Weight == 0)
            {
                sb.AppendLine("  Weight: n/a");
            }

            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }

            sb.AppendLine($"  Color: { this.Color}");
            return sb.ToString().Trim();
        }
    }
}
