int[] bounds = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

string criteria = Console.ReadLine();
int start = bounds[0];
int end = bounds[1];

List<int> numbers = new List<int>();

for (int i = start; i <= end; i++)
{
    numbers.Add(i);
}

Predicate<int> predicate = i => true;

if (criteria == "even")
{
    predicate = i => i %2 == 0;
}
else if (criteria == "odd")
{
    predicate = i => i % 2 != 0;
}

var filteredNumbers = numbers.Where(new Func<int, bool>(predicate));

Console.WriteLine(string.Join(" ", filteredNumbers));