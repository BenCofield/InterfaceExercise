using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int AvgMPG { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        
    }
}
