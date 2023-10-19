List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
int number = bomb[0];
int power = bomb[1];
while (list.Contains(number))
{
    int index = list.IndexOf(number);
    int leftIndex = Math.Max(0, index - power);
    int rightIndex = Math.Min(list.Count - 1, index + power);
    int range = rightIndex - leftIndex + 1;
    list.RemoveRange(leftIndex, range);
}
Console.WriteLine(list.Sum());