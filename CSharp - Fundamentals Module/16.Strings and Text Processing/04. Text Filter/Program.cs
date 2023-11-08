using static System.Net.Mime.MediaTypeNames;
string[] banWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
foreach (var banWord in banWords)
{
    if (text.Contains(banWord))
    {
        text = text.Replace(banWord, new string('*', banWord.Length));
    }
}
Console.WriteLine(text);