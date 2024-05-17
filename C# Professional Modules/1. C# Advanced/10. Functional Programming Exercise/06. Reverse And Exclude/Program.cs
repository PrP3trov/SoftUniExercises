int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int divisor = int.Parse(Console.ReadLine());

Predicate<int> predicate = i => i % divisor != 0;

var result = numbers.Where(number => predicate(number)).ToArray();

Console.WriteLine(string.Join(" ",result.Reverse()));