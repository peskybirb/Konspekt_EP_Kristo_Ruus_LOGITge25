using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esimeneprojekt.Vehicles;

namespace esimeneprojekt.Vehicles
{
    public enum CarMark
    {
        Toyota,BMW,Ford,Subaru,Honda,Volvo,Škoda,Trashla,Mini,Subuwu,
    }
    public class Vehicle
    {
        public Vehicle(string model,CarMark mark, string plate, string colour,decimal unloadedWeight,List<string> equipment)
        {
            Model = model;
            Mark = mark;
            Plate = plate;
            Colour = colour;
            EmptyWeight = unloadedWeight;
            Equipment = equipment;
        }
        public string Model { get; set; }
        public CarMark Mark { get; set; }
        public string Plate { get; set; }  
        public string Colour { get; set; }
        public decimal EmptyWeight { get; set; } = 0; // one unit is one ton
        public List<string>? Equipment { get; set; }

        /// <summary>
        /// Returns info about this car
        /// </summary>
        /// <returns>Human readable sentence as a string</returns>
        public virtual string GetInfo()
        {
            return $"This is a {Mark} {Model} it is {Colour} color and weighs {EmptyWeight} tons\n License plate is {Plate}";
        }
        public void SeeEquipment()
        {
            Console.WriteLine("This car has: ");
            foreach(var thing in Equipment)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
