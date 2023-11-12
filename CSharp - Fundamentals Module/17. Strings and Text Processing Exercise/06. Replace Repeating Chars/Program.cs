using System.Text;

string input = Console.ReadLine();
StringBuilder resultBuilder = new StringBuilder();
resultBuilder.Append(input[0]);
for (int i = 1; i < input.Length; i++)
{
    if (input[i] != input[i - 1])
    {
        resultBuilder.Append(input[i]);
    }
}
Console.WriteLine(resultBuilder);