using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esimeneprojekt.Vehicles;

namespace esimeneprojekt.Vehicles
{

    public class Train : Vehicle
    {
        public Train(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }

        public int vaguniteArv { get; set; }
        public double vaguniPikkus { get; set; }
        public int vaguniteInimMahtuvus { get; set; }




        public override string GetInfo()
        {
            return $"This is a {Mark}{Model} it is {Colour} colour and has {vaguniteArv} traincars, one car is {vaguniPikkus}, each car can fit {vaguniteInimMahtuvus} people";
        }
    }
}
