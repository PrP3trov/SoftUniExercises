namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car car = new();

        car.Make = "VW";
        car.Model = "MK3";
        car.Year = 1992;
    }
}