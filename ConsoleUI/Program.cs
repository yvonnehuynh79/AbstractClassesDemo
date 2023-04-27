using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Done Create an abstract class called Vehicle
             * Done The vehicle class shall have three string properties Year, Make, and Model
             * Done Set the defaults to something generic in the Vehicle class
             * Done Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Done Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicles> vehicles = new List<Vehicles>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = 2000,
                Make = "Dodge",
                Model = "Caravan"
            };

            var motorcycle1 = new Motorcycle()
            {
                HasSideCart = true,
                Year = 2023,
                Make = "Honda",
                Model = "Suzuki"
            };

            Vehicles vehicle1 = new Car()
            {
                HasTrunk = true,
                Year = 2023,
                Make = "Toyota",
                Model = "Sienna"
            };
            Vehicles vehicle2 = new Motorcycle()
            {
                HasSideCart = false,
                Year = 1999,
                Make = "Kawasaki",
                Model = "Ninja"
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            // Call each of the drive methods for one car and one motorcycle
            foreach(var car in vehicles)
            {
                Console.WriteLine("Car information:");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model:{car.Model}");
                car.DriveAbstract();
                car.DriveVirtual();
            }
            #endregion            
            Console.ReadLine();
        }
    }
}
