using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int AvgMPG { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string CountryOrigin { get; set; }
        public bool Imported { get; set; }

        public int NumSeats { get; set; }
        public bool AWD { get; set; }
    }
}
