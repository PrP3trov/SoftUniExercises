double[] input = Console.ReadLine().Split(", ").Select(double.Parse).Select(n => n*1.2).ToArray();
foreach (var item in input)
{
    Console.WriteLine($"{item:F2}");
}