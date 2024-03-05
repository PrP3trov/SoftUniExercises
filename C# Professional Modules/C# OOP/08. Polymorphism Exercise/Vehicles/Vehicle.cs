namespace Vehicles
{
    public abstract class Vehicle : IDrivable, IRefuable
    {
		private double _fuelQuantity;
		private double _fuelConsumption;

        protected Vehicle(double fuelConsumption, double fuelQuantity)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public double FuelConsumption
		{
			get { return _fuelConsumption; }
			protected set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Consumption must be positive number");
                }
                _fuelConsumption = value;
            }
		}
		public double FuelQuantity
		{
			get 
			{
				return _fuelQuantity; 
			}
			protected set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Fuel must be positive number");
				}
				_fuelQuantity = value;
			}
		}

        public virtual void Drive(double distance)
        {
			double totalConsumption = distance * FuelConsumption;
			if (totalConsumption > FuelQuantity)
			{
                Console.WriteLine($"{this.GetType().Name} needs refueling");
			}
			else
			{
                FuelQuantity -= totalConsumption;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }         
        }

        public virtual void Refuel(double fuelAmount)
        {
			if (fuelAmount < 0)
			{
                Console.WriteLine("Fuel must be a positive number");
            }
			else
			{
                FuelQuantity += fuelAmount;
            }
        }
    }
}
