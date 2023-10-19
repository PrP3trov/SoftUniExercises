using System.ComponentModel.Design;

List<string> party =  new List<string>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string name = arguments[0];
    if (arguments[2] == "going!")
    {
        if (party.Exists(e => e == name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            party.Add(name);
        }
    }
    else if(arguments[2] == "not")
    {
        if (party.Contains(name))
        {
            party.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }        
}
for (int i = 0; i < party.Count; i++)
{
    Console.WriteLine(party[i]);
}