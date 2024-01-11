using System;
using System.Security.Cryptography;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo1 = int.Parse(Console.ReadLine());
            int chislo2 = int.Parse(Console.ReadLine());           
            for (int i = chislo1; i <= chislo2; i++)
            {
                 string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if(j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }

            }           
        }
    }
}
