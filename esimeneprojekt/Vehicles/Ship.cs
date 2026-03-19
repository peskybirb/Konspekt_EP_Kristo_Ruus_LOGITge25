using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esimeneprojekt.Vehicles;

namespace esimeneprojekt.Vehicles
{
    internal class Ship : Vehicle
    {
        public double leavaPikkus {  get; set; }
        public double displacementVolume { get; set; }
        public Ship(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
    }
}
