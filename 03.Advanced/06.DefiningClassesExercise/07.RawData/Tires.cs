using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Tire
    {
        public Tire(double tirePressure, int tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;
        }

        public int TireAge { get; set; }
        public double TirePressure { get; set; }
    }
}