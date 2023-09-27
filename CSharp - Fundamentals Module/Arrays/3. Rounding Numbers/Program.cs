string numbers = Console.ReadLine();
double[] array = numbers.Split().Select(double.Parse).ToArray();
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]} => {(int)Math.Round(array[i], MidpointRounding.AwayFromZero)}");
}