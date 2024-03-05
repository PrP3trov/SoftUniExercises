namespace VehiclesExtension
{
    public abstract class Vehicle : IDrivable, IRefuable
    {
		private double _fuelQuantity;
		private double _fuelConsumption;
		private double _tankCapacity;
		protected Vehicle(double fuelConsumption, double fuelQuantity, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public double TankCapacity
        {
            get { return _tankCapacity; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Tank capacity must be positive number");
                }
                _tankCapacity = value;
            }
        }
        public double FuelConsumption
		{
			get { return _fuelConsumption; }
			protected set 
			{
                if (value <= 0)
                {
                    throw new ArgumentException("Consumption must be positive number");
                }
                _fuelConsumption = value;
            }
		}
		public double FuelQuantity
		{
			get {return _fuelQuantity;}
			protected set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Fuel must be positive number");
				}

                if (value <= TankCapacity)
                {
                    _fuelQuantity = value;
                }
                else
                {
                    _fuelQuantity = 0;
                }
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
			if (fuelAmount <= 0)
			{
               throw new ArgumentException("Fuel must be a positive number");
            }
            double totalFuelAfterRefueling = fuelAmount + FuelQuantity;
            if (totalFuelAfterRefueling > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }

            FuelQuantity += fuelAmount;                   
        }

    }
}
