List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] arguments = input.Split();
    if (arguments[0] == "Add")
    {
        int passengers = int.Parse(arguments[1]);
        train.Add(passengers);
    }
    else
    {
        int newPassengers = int.Parse(arguments[0]);

        for (int i = 0; i < train.Count; i++)
        {
            if (train[i] + newPassengers <= maxCapacity)
            {
                train[i] += newPassengers;
                break;
            }
        }
    }
}
Console.WriteLine(string.Join(" ",train));