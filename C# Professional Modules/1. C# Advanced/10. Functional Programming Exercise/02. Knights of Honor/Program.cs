string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
Action<string> print = s => Console.WriteLine($"Sir {s}");

Array.ForEach(input, print);