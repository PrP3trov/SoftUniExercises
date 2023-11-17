int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (sum + num <= 255)
    {
        sum += num;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}
Console.WriteLine(sum);