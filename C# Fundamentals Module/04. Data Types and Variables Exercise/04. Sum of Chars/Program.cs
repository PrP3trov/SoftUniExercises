long sum  = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    char leter = char.Parse(Console.ReadLine());
    sum += leter;
}
Console.WriteLine($"The sum equals: {sum}");