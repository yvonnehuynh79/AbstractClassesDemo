using System;
namespace ConsoleUI
{
	public class Car : Vehicles
	{
		public Car()
		{
		}
        public bool HasTrunk{ get; set; }

    public override void DriveAbstract()
        {
            Console.WriteLine($"Driving a CAR {Make} with an ABSTRACT method");
        }
    }
}

