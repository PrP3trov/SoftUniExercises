List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
int limit1 = firstPlayer.Count;
int limit2 = secondPlayer.Count;
while (true)
{
    if (limit1==0 || limit2 == 0)
    {
        break;
    }
    if (firstPlayer[0] > secondPlayer[0])
    {
        firstPlayer.Add(firstPlayer[0]);
        firstPlayer.Add(secondPlayer[0]);
        firstPlayer.RemoveAt(0);
        secondPlayer.RemoveAt(0);

    }
    else if (firstPlayer[0] < secondPlayer[0])
    {
        secondPlayer.Add(secondPlayer[0]);
        secondPlayer.Add(firstPlayer[0]); 
        secondPlayer.RemoveAt(0);
        firstPlayer.RemoveAt(0);
    }
    else if (firstPlayer[0] == secondPlayer[0])
    {
        firstPlayer.RemoveAt(0);
        secondPlayer.RemoveAt(0);
    }
    limit1 = firstPlayer.Count;
    limit2 = secondPlayer.Count;
}
if (firstPlayer.Count== 0)
{
    Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");

}
else
{
    Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
}