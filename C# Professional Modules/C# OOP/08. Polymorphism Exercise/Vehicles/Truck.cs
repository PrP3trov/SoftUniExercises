namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double FuelConsumptionModifier = 1.6;
        private const double TruckerFactor = 0.95;
        public Truck(double fuelConsumption, double fuelQuantity) : base(fuelConsumption + FuelConsumptionModifier, fuelQuantity)
        {
        }
        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * TruckerFactor);
        }
    }
}
