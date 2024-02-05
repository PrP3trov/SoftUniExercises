namespace Generics
{
    public class StartUp
    {
        static void Main()
        {
            string[] nameTokens = Console.ReadLine().Split().ToArray();
            string[] beerTokens = Console.ReadLine().Split().ToArray();
            string[] numberTokens = Console.ReadLine().Split().ToArray();
            CustomTuple<string, string> names = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2]);
            CustomTuple<string, int> beers = new(beerTokens[0], int.Parse(beerTokens[1]));
            CustomTuple<int, double> numbers = new(int.Parse(numberTokens[0]), double.Parse(numberTokens[1]));
            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(numbers);
        }
    }
}