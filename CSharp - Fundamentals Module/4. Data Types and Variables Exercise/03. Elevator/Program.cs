int people = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());
int cources = (int)Math.Ceiling((double)people / capacity);
Console.WriteLine(cources);