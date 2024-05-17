HashSet<string> invited = new HashSet<string>();
HashSet<string> REGULAR = new HashSet<string>();
HashSet<string> VIP = new HashSet<string>();
while (true)
{
    string command = Console.ReadLine();
   
    if ( command.Length == 8)
    {
        invited.Add(command);
    }

     if (command == "PARTY")
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {

                break;              
            }
            else
            {
                invited.Remove(input);
            }
        }
        break;
    }
}
Console.WriteLine(invited.Count);
foreach (var gues in invited)
{
    if (char.IsDigit(gues[0]))
    {
        VIP.Add(gues);
    }
    else
    {
        REGULAR.Add(gues);
    }
}
if (VIP.Any())
{
    Console.WriteLine(string.Join("\n", VIP));
}
if (REGULAR.Any())
{

Console.WriteLine(string.Join("\n",REGULAR));
}