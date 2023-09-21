int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    int num = i;
    string number1 = i.ToString();
    for (int j = 0; j < number1.Length; j++)
    {
        sum += num % 10; 
        num /= 10; 
    }
    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else Console.WriteLine($"{i} -> False");
    sum = 0;
    
}