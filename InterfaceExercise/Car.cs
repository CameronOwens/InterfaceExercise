using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
		public Car()
		{
		}

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Charger";
        public int DoorCount { get; set; } = 4;
        public bool HasChangedGears { get; set; }
        public string Name { get; set; } = "Dodge";
        public string Logo { get; set; } = "Ram";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forward.");
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

