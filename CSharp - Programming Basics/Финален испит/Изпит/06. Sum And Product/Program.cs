using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace _06._Sum_And_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int prozivednie = 0;
            string chislo = "";
            string drugo = "";
            bool flag = true;
            bool pedal = false;

                for (int a = 1; a <= 9; a++)
                {
                    for (int b = 9; b >= a; b--)
                    {
                        for (int c = 0; c <= 9; c++)
                        {
                            for (int d = 9; d >= c; d--)
                            {
                                chislo = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                                sum = a + b + c + d;
                                prozivednie = a * b * c * d;
                                if (sum == prozivednie && n % 10 == 5)
                                {
                                    Console.WriteLine(chislo);
                                flag = false;
                                pedal = true;
                                    break;
                                }
                                if (prozivednie / sum == 3 && n % 3 == 0)
                                {
                                    drugo = d.ToString() + c.ToString() + b.ToString() + a.ToString();
                                    Console.WriteLine(drugo);
                                flag = false;
                                pedal = true;
                                    break;
                                }
                            }
                            if (pedal)
                            {
                                break;
                            }
                        }
                        if (pedal)
                        {
                            break;
                        }
                    }
                    if (pedal)
                    {
                        break;
                    }

                }                          
           if (flag) Console.WriteLine($"Nothing found");
        }
    }
}
