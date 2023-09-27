int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sum = 0; int sum1 = 0;
for (int i = 0; i < array.Length; i++)
{
    int number1 = array[i];
    int number2 = array2[i];
    if (number1 != number2)
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        sum = -2;
        break;
    }
    else 
    { 
        sum += number1;
        sum1 += number2;
    }
}
if (sum == sum1)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}