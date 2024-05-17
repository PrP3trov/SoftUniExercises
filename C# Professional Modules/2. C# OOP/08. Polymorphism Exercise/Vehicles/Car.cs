namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double FuelConsumptionModifier = 0.9;

        public Car(double fuelConsumption, double fuelQuantity) : base(fuelConsumption + FuelConsumptionModifier, fuelQuantity)
        {
        }
    }
}
