int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sum = 0, sum1 = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int number = numbers[i];
    if (number % 2 == 0)
    {
        sum += number;
    }
    else
    {
        sum1 += number;
    }

}
Console.WriteLine(sum - sum1);