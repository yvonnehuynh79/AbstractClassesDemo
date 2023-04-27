using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicles
	{
		public Motorcycle()
		{
		}
        public bool HasSideCart { get; set; }

    public override void DriveAbstract()
        {

            Console.WriteLine($"Dring a MOTORCYCLE, {Make}, with an ABSTRACT method");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Driving a MOTORCYCLE, {Make}, with a VIRTUAL method");
        }
    }
}

