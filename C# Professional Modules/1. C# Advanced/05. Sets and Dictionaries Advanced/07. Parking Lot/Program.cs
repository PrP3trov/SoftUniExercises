HashSet<string> cars = new HashSet<string>();

while (true)
{
    string[] command = Console.ReadLine().Split(", ");
    if (command[0] == "END")
    {
        if (cars.Any())
        {
            Console.WriteLine(string.Join("\n", cars));
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
        break;
    }
    else if (command[0] == "IN")
    {
        cars.Add(command[1]);
    }
    else if (command[0] == "OUT")
    {
        cars.Remove(command[1]);
    }
}