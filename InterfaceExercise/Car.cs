using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int AvgMPG { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string CountryOrigin { get; set; }
        public bool Imported { get; set; }

        public bool ElectricVehicle { get; set; }
        public string Type { get; set; } //Hatchback, sedan, coupe
    }
}
