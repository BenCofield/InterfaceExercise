using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string CountryOrigin { get; set; }
        public bool Imported { get; set; }
    }
}
