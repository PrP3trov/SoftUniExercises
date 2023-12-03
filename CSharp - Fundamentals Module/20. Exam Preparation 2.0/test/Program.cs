int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());
string replace = key.Substring(startIndex, endIndex - startIndex);
string upper = key.Substring(startIndex, endIndex - startIndex).ToLower();
key = key.Replace(replace, upper);
Console.WriteLine(key);