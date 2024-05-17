int lenght = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ");

Predicate<string> precicate = s => s.Length <= lenght;
var result = names.Where(name => precicate(name));
Console.WriteLine(string.Join("\n",result));