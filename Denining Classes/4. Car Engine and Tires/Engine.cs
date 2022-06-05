using System;
using System.Collections.Generic;
using System.Text;


    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsePowers,double cubicCapacity)
        {
            this.HorsePower = horsePowers;
            this.CubicCapacity = cubicCapacity;
        }
    }

