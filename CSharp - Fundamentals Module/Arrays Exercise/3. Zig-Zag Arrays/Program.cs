int n = int.Parse(Console.ReadLine());
bool a = true;
string[] array = new string[n];
string[] array2 = new string[n];
for (int i = 0; i <n; i++)
{
    string numbers = Console.ReadLine();
    string[] numbersArray = numbers.Split();
    if (a)
    {
        array[i] = numbersArray[0];
        array2[i] = numbersArray[1];
    }
    else
    {
        array[i] = numbersArray[1];
        array2[i] = numbersArray[0];
    }
    a = !a;
}
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(string.Join(" ", array2));