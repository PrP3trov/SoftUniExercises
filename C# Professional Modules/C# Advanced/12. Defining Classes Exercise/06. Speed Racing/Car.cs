namespace DefiningClasses;

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TravelledDistance { get; set; }
    public Car()
    {
        TravelledDistance = 0;
    }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
    }

    public void Calculate(double fuelAmount, double fuelCosumption, double amountOfKm)
    {
        if (fuelAmount >= amountOfKm * fuelCosumption)
        {
            fuelAmount -= amountOfKm * fuelCosumption;
            FuelAmount = fuelAmount;
            TravelledDistance += amountOfKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}