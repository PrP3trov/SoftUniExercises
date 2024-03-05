namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        public const double ConsumptionModifier = 1.4;  
        public Bus(double fuelConsumption, double fuelQuantity, double tankCapacity) 
            : base(fuelConsumption, fuelQuantity, tankCapacity)
        {
        }

        public void DriveWithPeople(double distance)
        {
            var totalConsumption = distance * (FuelConsumption + ConsumptionModifier);
            if (FuelQuantity >= totalConsumption)
            {
                FuelQuantity -= totalConsumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                throw new ArgumentException("Bus needs refueling");
            }
        }
    }
}
