using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esimeneprojekt.Vehicles;

namespace esimeneprojekt.Vehicles
{
    //kasutades koolonit saab anda pärilusena teisest klassist omadusi ja meetodeid , antud juhul saadakse info klassis Vehicle 
    //uuele klassile Car saab anda uus väärtusi mis klassis vehicle ei ole mis täpsustab antud klassi olemust
    public class Car : Vehicle
    {
        public int BootVolume { get; set; } // omadus mida klassis Vehicle ei ole , ning on omane pige tavalisele sõiduautole
        public int SeatCount { get; set; } // omadus mida klassis Vehicle ei ole , ning on omane pige tavalisele sõiduautole
        public Car(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
    }
}
