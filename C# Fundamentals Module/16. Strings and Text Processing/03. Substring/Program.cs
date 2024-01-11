using static System.Net.Mime.MediaTypeNames;

string remove = Console.ReadLine();
string result = Console.ReadLine();
int index = result.IndexOf(remove);
while (index != -1)
{
    result = result.Remove(index, remove.Length);
    index = result.IndexOf(remove);
}
Console.WriteLine(result);
