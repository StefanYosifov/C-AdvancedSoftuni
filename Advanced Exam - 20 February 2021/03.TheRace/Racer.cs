﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Racer
    {
        public Racer(string name, int age, string country, Car car)
        {
            Name = name;
            Age = age;
            Country = country;
            this.car = car;
        }


        public string Name { get; set; }
        public int Age { get; set; }

        public string Country { get; set; }

        public Car car { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racer: {Name}, {Age} ({Country})");
            return sb.ToString().TrimEnd();
        }
    }
}
