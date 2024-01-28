string[] words = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Predicate<string> checker = word => char.IsUpper(word[0]);

words = words.Where(w => checker(w)).ToArray();

Console.WriteLine(string.Join("\n", words));
