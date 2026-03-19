using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esimeneprojekt.Vehicles;

namespace esimeneprojekt.Vehicles
{
    //kasutades koolonit saab anda pärilusena teisest klassist omadusi ja meetodeid , antud juhul saadakse info klassis Vehicle 
    //uuele klassile Lennuk saab anda uus väärtusi mis klassis vehicle ei ole mis täpsustab antud klassi olemust

    public enum TravelClass
    {
        FirstClass, SecondClass, TouristClass, BaggageRoom
    }
    internal class Plane : Vehicle
    {
        public int lennuKiirus {  get; set; } // omadus mida klassis Vehicle ei ole , ning on omane pige tavalisele Lennukile
        public double tiivaLaius { get; set; } // omadus mida klassis Vehicle ei ole , ning on omane pige tavalisele Lennukile


        public Plane(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
    }
}
