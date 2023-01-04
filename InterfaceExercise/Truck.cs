using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle , ICompany
	{
		public Truck()
		{
		}

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Ram";
        public int DoorCount { get; set; } = 4;
        public bool HasChangedGears { get; set; }
        public string Name { get; set; } = "Dodge";
        public string Logo { get; set; } = "Ram";

        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} is now driving forward.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving.");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in reverse.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we shift gears.");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now parked.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't psrk until we shift gears.");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

