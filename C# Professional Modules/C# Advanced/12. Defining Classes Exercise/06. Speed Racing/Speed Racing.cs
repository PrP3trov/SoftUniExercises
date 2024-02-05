namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string model = input[0];
            double fuelAmount = double.Parse(input[1]);
            double fuelConsumptionFor1km = double.Parse(input[2]);
            Car car = new Car(model,fuelAmount,fuelConsumptionFor1km);
            cars.Add(car);
            
        }
        string a;
        while ((a = Console.ReadLine()) != "End")
        {
            string[] command = a.Split();
            double amountOfKm = double.Parse(command[2]);
            string carModel = command[1];
            foreach (var item in cars)
            {
                if (item.Model == carModel)
                {
                    item.Calculate(item.FuelAmount, item.FuelConsumptionPerKilometer, amountOfKm);
                }
            }
            
        }
        foreach (var item in cars)
        {
            Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
        }           
    }
}