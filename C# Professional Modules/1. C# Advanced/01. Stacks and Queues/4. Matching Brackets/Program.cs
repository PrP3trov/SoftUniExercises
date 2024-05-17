using System.Threading.Channels;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = brackets.Pop();
                    int end = i;
                    string result = input.Substring(start, end - start+1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}