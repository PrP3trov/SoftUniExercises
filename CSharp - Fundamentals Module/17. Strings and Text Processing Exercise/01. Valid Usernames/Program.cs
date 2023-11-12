using System.Globalization;

string[] names = Console.ReadLine().Split(", ").ToArray();
foreach(string name in names)
{
    if (name.Length <3 || name.Length > 16)
    {
        continue;
    }
    if (isValidUser(name))
    {
        Console.WriteLine(name);
    }
}
static bool isValidUser(string name)
{
    return name.All(ch => char.IsLetterOrDigit(ch) || ch == '_' || ch == '-');
}


    
