using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            int result = Math.Abs(GetSumOfOddDigits(num) * GetSumOfEvenDigits(num));
            return result;
        }
        static int GetSumOfOddDigits(int num)
        {          
            int sumOdd = 0;
            string a = num.ToString();
            for (int i = 0; i < a.Length; i++)
            {
                int check = num % 10;
                if (check % 2 != 0)
                {
                    sumOdd += check;
                }
                num /= 10;
            }
            return sumOdd;
        }
        static int GetSumOfEvenDigits(int num)
        {
            int sumEven = 0;
            string a = num.ToString();
            for (int i = 0; i < a.Length; i++)
            {
                int check = num % 10;
                if (check % 2 == 0)
                {
                    sumEven += check;
                }
                num /= 10;
            }
            return sumEven;
        }
    }
}
