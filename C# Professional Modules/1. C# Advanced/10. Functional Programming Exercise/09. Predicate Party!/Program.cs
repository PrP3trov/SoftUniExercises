List<string> guessList = Console.ReadLine().Split().ToList();
while (true)
{
    string input = Console.ReadLine();  
    if (input == "Party!")
    {
        break;
    }
    string[] command = input.Split();
    Func<string, bool> predicate = GetPredicate(command[1], command[2]);

    switch (command[0])
    {
        case "Remove":
            guessList = Remove(guessList, predicate);
            break;
        case "Double":
            guessList = Double(guessList, predicate);
            break;
    }
}
Console.WriteLine(guessList.Any()
    ? $"{string.Join(", ", guessList)} are going to the party!"
    : "Nobody is going to the party!"
    );

Func<string, bool> GetPredicate(string command, string substring)
{
    if (command == "StartsWith")
    {
        return s => s.StartsWith(substring);
    }
     if (command == "EndsWith")
    {
        return s => s.EndsWith(substring);

    }
    if (command == "Length")
    {
        return s => s.Length == int.Parse(substring);
    }
    return default;
}

static List<string> Double(List<string> guestList, Func<string, bool> predicate)
{
    List<string> result = new List<string>();
    foreach (string guest in guestList)
    {
        if (predicate(guest))
        {
            result.Add(guest);
        }
        result.Add(guest);
    }
    return result;
}

static List<string> Remove(List<string> guestList,Func<string,bool> predicate)
{
    guestList = guestList.Where(guest => predicate(guest) == false).ToList();
    return guestList;
}