using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            List<IVehicle> vehicles = new List<IVehicle>();

            Car car1 = new Car
            {
                Year = 2013,
                Make = "Honda",
                Model = "Civic",
                AvgMPG = 28,

                CountryOrigin = "Japan",
                Imported = true,

                ElectricVehicle = false,
                Type = "Sedan",
            }; vehicles.Add(car1);


            Truck truck1 = new Truck
            {
                Year = 2010,
                Make = "Ford",
                Model = "F150",
                AvgMPG = 15,

                CountryOrigin = "United States",
                Imported = false,

                BedLength = 210,
                NumDoors = 4,
            }; vehicles.Add(truck1);

            SUV suv1 = new SUV
            {
                Year = 2015,
                Make = "Hyundai",
                Model = "Tucson",
                AvgMPG = 23,

                CountryOrigin = "South Korea",
                Imported = true,

                AWD = true,
                NumSeats = 5,
            }; vehicles.Add(suv1);

            Console.WriteLine("Vehicle List: ");
            int i = 0;
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{i}: {vehicle.Year} {vehicle.Make} {vehicle.Model}\n" +
                                  $"\tAverage MPG: {vehicle.AvgMPG}");
                i++;
                if (vehicle is Car)
                {
                    Car v1 = vehicle as Car;
                    Console.WriteLine($"\tModel Type: {v1.Type}");

                    if (v1.ElectricVehicle) Console.WriteLine("\tElectric Vehicle");

                    var isImported = (v1.Imported) ? $"Imported from {v1.CountryOrigin}" : v1.CountryOrigin;
                    Console.WriteLine($"\t{isImported}");
                }

                else if (vehicle is Truck)
                {
                    Truck v1 = vehicle as Truck;
                    Console.WriteLine($"\tDoors: {v1.NumDoors}\n" +
                                      $"\tBed Length: {v1.BedLength}cm");

                    var isImported = (v1.Imported) ? $"Imported from {v1.CountryOrigin}" : v1.CountryOrigin;
                    Console.WriteLine($"\t{isImported}");
                }
                else if (vehicle is SUV)
                {
                    SUV v1 = vehicle as SUV;
                    var isAWD = (v1.AWD) ? $"All wheel drive" : $"Two wheel drive";
                    Console.WriteLine($"\t{isAWD}");

                    var isImported = (v1.Imported) ? $"Imported from {v1.CountryOrigin}" : $"{v1.CountryOrigin}";
                    Console.WriteLine($"\t{isImported}");

                }
            }
        }
    }
}
