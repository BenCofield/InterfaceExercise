using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int AvgMPG { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string CountryOrigin { get; set; }
        public bool Imported { get; set; }
        
        public int NumDoors { get; set; }
        public double BedLength { get; set; } //centimeters
    }
}
