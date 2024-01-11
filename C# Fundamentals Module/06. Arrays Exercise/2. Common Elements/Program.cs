string[] array = Console.ReadLine().Split(" ").ToArray();
string[] array1 = Console.ReadLine().Split(" ").ToArray();
foreach (string str in array1)
{
    if (array.Contains(str))
    {
        Console.Write(str + " ");
    }
}