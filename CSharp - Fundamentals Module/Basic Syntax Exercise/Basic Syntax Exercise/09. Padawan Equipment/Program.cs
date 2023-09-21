internal class Program
{
    private static void Main(string[] args)
    {
        double moneyhas = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double priceLightsaber = double.Parse(Console.ReadLine());
        double priceRobes = double.Parse(Console.ReadLine());
        double pricebelts = double.Parse(Console.ReadLine());
        double lightsabersneeded = Math.Ceiling(students * 0.10 + students);
        double freeBelts = students / 6;
        double sum = priceRobes * students + priceLightsaber * lightsabersneeded + pricebelts * (students - freeBelts);
        if (sum <= moneyhas)
        {
            Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
        }
        else Console.WriteLine($"John will need {sum - moneyhas:F2}lv more.");
    }

}