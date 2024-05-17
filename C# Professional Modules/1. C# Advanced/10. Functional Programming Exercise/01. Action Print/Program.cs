string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
Action<string> print = s => Console.WriteLine(s);

Array.ForEach(input, print);