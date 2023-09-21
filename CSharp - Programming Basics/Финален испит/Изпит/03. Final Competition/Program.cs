using System;

namespace _03._Final_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tanciori = int.Parse(Console.ReadLine());
            double tochki = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string mqsto = Console.ReadLine();
            double sum = 0;
            double blagotvoritelnost = 0;
            double paritancior = 0;
            switch (mqsto)
            {
                case "Bulgaria":
                    {
                        sum = tanciori * tochki;
                        switch (sezon)
                        {
                            case "summer":
                                sum = sum - sum *  0.05;
                                blagotvoritelnost = sum * 0.75;
                                sum = sum - blagotvoritelnost;
                                paritancior = sum / tanciori;
                                break;
                            case "winter":
                                sum = sum - sum * 0.08;
                                blagotvoritelnost = sum * 0.75;
                                sum = sum - blagotvoritelnost;
                                paritancior = sum / tanciori;
                                break;
                        }
                    }
                    break;
                case "Abroad":
                    {
                        sum = tanciori * tochki;
                        sum = sum + sum * 0.50;
                        switch (sezon)
                        {
                            case "summer":
                                sum = sum - sum * 0.10;
                                blagotvoritelnost = sum * 0.75;
                                sum = sum - blagotvoritelnost;
                                paritancior = sum / tanciori;
                                break;
                            case "winter":
                                sum = sum - sum * 0.15;
                                blagotvoritelnost = sum * 0.75;
                                sum = sum - blagotvoritelnost;
                                paritancior = sum / tanciori;
                                break;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Charity - {blagotvoritelnost:F2}");
            Console.WriteLine($"Money per dancer - {paritancior:F2}");
        }
    }
}
