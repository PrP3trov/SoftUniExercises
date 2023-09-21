using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string razmer = Console.ReadLine();
            string cvqt = Console.ReadLine();
            int brpartidi = int.Parse(Console.ReadLine());
            double cena = 0, razhod = 0, sum = 0;           
            switch (razmer)
            {
                case "Large":
                    {
                        switch(cvqt)
                        {
                            case "Red": cena = brpartidi * 16; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                            case "Green":
                                cena = brpartidi * 12; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.") ;
                                break;
                            case "Yellow":
                                cena = brpartidi * 9; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                        }
                    }
                    break;
                case "Medium":
                    {
                        switch (cvqt)
                        {
                            case "Red":
                                cena = brpartidi * 13; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                            case "Green":
                                cena = brpartidi * 9; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                            case "Yellow":
                                cena = brpartidi * 7; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                        }
                    }
                    break;
                case "Small":
                    {
                        switch (cvqt)
                        {
                            case "Red":
                                cena = brpartidi * 9; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                            case "Green":
                                cena = brpartidi * 8; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                            case "Yellow":
                                cena = brpartidi * 5; razhod = 0.35 * cena; sum = cena - razhod;
                                Console.WriteLine($"{sum:F2} leva.");
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
