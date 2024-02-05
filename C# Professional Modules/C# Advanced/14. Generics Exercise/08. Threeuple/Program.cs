namespace Generics
{
    public class StartUp
    {
        static void Main()
        {
            string[] nameTokens = Console.ReadLine().Split().ToArray();
            string[] beerTokens = Console.ReadLine().Split().ToArray();
            string[] bankTokens = Console.ReadLine().Split().ToArray();
            Threeuple<string, string, string> names = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2], nameTokens[3]);
            Threeuple<string, int, bool> beers = new(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");
            Threeuple<string, double, string> bank = new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);
            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(bank);
        }
    }
}