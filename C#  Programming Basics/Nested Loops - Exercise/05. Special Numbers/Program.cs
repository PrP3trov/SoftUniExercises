using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                bool isMagicNumber = true;
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    int lastDigid = currentNumber % 10;
                    currentNumber /= 10;
                    if (lastDigid == 0)
                    {
                        isMagicNumber = false;
                        break;
                    }
                    if(n % lastDigid != 0)
                    {
                        isMagicNumber = false;
                        break;
                    }
                }
                if (isMagicNumber)
                {
                    Console.Write(i + " ");
                }
            }
                      
        }
    }
}
