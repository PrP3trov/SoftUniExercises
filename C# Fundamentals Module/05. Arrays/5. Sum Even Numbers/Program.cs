int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int number = numbers[i];
    if (number %2 == 0)
    {
        sum += number;
    }

}
Console.WriteLine(sum);