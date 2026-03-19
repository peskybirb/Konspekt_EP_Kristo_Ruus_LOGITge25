using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esimeneprojekt.Vehicles;

namespace esimeneprojekt.NewFolder
{
    //kasutades koolonit saab anda pärilusena teisest klassist omadusi ja meetodeid , antud juhul saadakse info klassis Vehicle 
    //uuele klassile Truck saab anda uus väärtusi mis klassis vehicle ei ole mis täpsustab antud klassi olemust
    internal class Truck
    {

        public double LoadWeight {  get; set; } // omadus mida klassis Vehicle ei ole , ning on omane pigem tavalisele rekkale
        public double EnginePower { get; set; } // omadus mida klassis Vehicle ei ole , ning on omane pigem tavalisele rekkale


    }
}
