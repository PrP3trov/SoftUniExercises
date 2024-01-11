List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
if (numbers.Count %2 == 0)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] += numbers[numbers.Count - 1];
        numbers.RemoveAt(numbers.Count - 1);
    }
}
else
{
    for (int i = 0; i < numbers.Count/2; i++)
    {
        numbers[i] += numbers[numbers.Count - 1];
        numbers.RemoveAt(numbers.Count - 1);
    }
}

Console.WriteLine(string.Join(" ",numbers));