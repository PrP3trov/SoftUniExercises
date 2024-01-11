using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string duma = Console.ReadLine();
            for (int i = 0; i < duma.Length; i++)
            {
                char bukva = duma[i];
                switch (bukva)
                {
                    case 'a': sum += 1;
                        break;
                    case 'e': sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }   
            }
            Console.WriteLine(sum);
        }
    }
}
