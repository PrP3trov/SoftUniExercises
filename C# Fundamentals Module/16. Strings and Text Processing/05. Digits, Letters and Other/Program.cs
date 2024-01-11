using System.Threading.Channels;

string word = Console.ReadLine();
string digits = "";
string letters = "";
string chars = "";
for (int i = 0; i < word.Length; i++)
{
    if (Char.IsDigit(word[i]))
    {
        digits += word[i];
    }
    else if (Char.IsLetter(word[i]))
    {
        letters += word[i];
    }
else chars += word[i];
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(chars);