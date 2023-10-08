using System;
using System.Net.Http.Headers;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           
            for (int i = 1; i <= n; i++)
            {
                bool a = SumDigits(i);
                bool b = OddDigit(i);
                if (a && b)
                {
                    Console.WriteLine(i);
                }
            }

            static bool SumDigits(int i)
            {
                int sum = 0;
                int num = i;
                string a = i.ToString();
                for (int j = 0; j < a.Length; j++)
                {
                    sum = sum + num % 10;
                    num = num / 10;
                }
                if (sum % 8 == 0)
                {
                    return true;
                }
                else return false;
            }
            static bool OddDigit(int i)
            {              
                int num = i;
                int b = 0;
                string a = i.ToString();
                for (int j = 0; j < a.Length; j++)
                {
                    b = num % 10;
                    if (b % 2 != 0)
                    {
                        return true;
                    }
                    num = num / 10;               
                }
                return false;
            }
        }
    }
}
