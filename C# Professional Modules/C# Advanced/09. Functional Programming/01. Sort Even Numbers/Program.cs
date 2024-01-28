int[] numbers = Console.ReadLine()
    .Split(", ")
    .Select(n => int.Parse(n))
    .Where(n => n % 2 == 0)
    .OrderBy(n => n)
    .ToArray();
Console.WriteLine(string.Join(", ", numbers));