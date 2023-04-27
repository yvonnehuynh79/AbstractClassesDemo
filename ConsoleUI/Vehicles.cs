using System;
namespace ConsoleUI
{
	public abstract class Vehicles
	{
		
		public int Year { get; set; } = 2000;
		public string Make { get; set; } = "gerneric Make";
		public string Model { get; set; } = "gerneri Model";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine("The VEHICLE is driving with a VIRTUAL method ");
		}

    }
}

