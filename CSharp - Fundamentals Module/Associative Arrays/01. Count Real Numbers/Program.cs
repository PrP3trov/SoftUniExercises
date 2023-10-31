int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
var numbersOccuren = new SortedDictionary<int, int>();
for (int i = 0; i < numbers.Length; i++)
{
    int currentNum = numbers[i];
    if (!numbersOccuren.ContainsKey(currentNum))
    {
        numbersOccuren[currentNum] = 1;
    }
    else
    {
        numbersOccuren[currentNum]++;
    }
}
foreach (KeyValuePair<int,int> item in numbersOccuren)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}