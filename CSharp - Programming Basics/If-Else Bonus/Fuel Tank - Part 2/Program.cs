using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string gorivo = Console.ReadLine();
            double kolichestvoGorivo = double.Parse(Console.ReadLine());
            string klubKarta = Console.ReadLine();
            if (gorivo == "Gas")
            {
                if (klubKarta == "Yes" && kolichestvoGorivo >= 20 && kolichestvoGorivo <= 25)
                {
                    double krainacena = kolichestvoGorivo * 0.85;
                    Console.WriteLine($"{(krainacena - krainacena * 0.08):F2} lv.");
                }
                else if (klubKarta == "Yes" && kolichestvoGorivo > 25)
                {
                    double krainacena = kolichestvoGorivo * 0.85;
                    Console.WriteLine($"{(krainacena - krainacena * 0.10):F2} lv.");
                }
                else if (klubKarta == "Yes" && kolichestvoGorivo <20)
                {
                    double krainacena = kolichestvoGorivo * 0.85;
                    Console.WriteLine($"{krainacena:F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo >= 20 && kolichestvoGorivo <= 25)
                {
                    double krainacena = kolichestvoGorivo * 0.93;
                    Console.WriteLine($"{(krainacena - krainacena * 0.08):F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo > 25)
                {
                    double krainacena = kolichestvoGorivo * 0.93;
                    Console.WriteLine($"{(krainacena - krainacena * 0.10):F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo < 20)
                {
                    double krainacena = kolichestvoGorivo * 0.93;
                    Console.WriteLine($"{krainacena:F2} lv.");
                }
            }
            else if (gorivo == "Gasoline")
            {
                if (klubKarta == "Yes" && kolichestvoGorivo >= 20 && kolichestvoGorivo <= 25)
                {
                    double krainacena = kolichestvoGorivo * 2.04;
                    Console.WriteLine($"{(krainacena - krainacena * 0.08):F2} lv.");
                }
                else if (klubKarta == "Yes" && kolichestvoGorivo > 25)
                {
                    double krainacena = kolichestvoGorivo * 2.04;
                    Console.WriteLine($"{(krainacena - krainacena * 0.10):F2} lv.");
                }
                else if (klubKarta == "Yes" && kolichestvoGorivo < 20)
                {
                    double krainacena = kolichestvoGorivo * 2.04;
                    Console.WriteLine($"{krainacena:F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo >= 20 && kolichestvoGorivo <= 25)
                {
                    double krainacena = kolichestvoGorivo * 2.22;
                    Console.WriteLine($"{(krainacena - krainacena * 0.08):F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo > 25)
                {
                    double krainacena = kolichestvoGorivo * 2.22;
                    Console.WriteLine($"{(krainacena - krainacena * 0.10):F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo > 25)
                {
                    double krainacena = kolichestvoGorivo * 2.22;
                    Console.WriteLine($"{krainacena:F2} lv.");
                }
            }
            else if (gorivo == "Diesel")
            {
                if (klubKarta == "Yes" && kolichestvoGorivo >= 20 && kolichestvoGorivo <= 25)
                {
                    double krainacena = kolichestvoGorivo * 2.21;
                    Console.WriteLine($"{(krainacena - krainacena * 0.08):F2} lv.");
                }
                else if (klubKarta == "Yes" && kolichestvoGorivo > 25)
                {
                    double krainacena = kolichestvoGorivo * 2.21;
                    Console.WriteLine($"{(krainacena - krainacena * 0.10):F2} lv.");
                }
                if (klubKarta == "Yes" && kolichestvoGorivo <20)
                {
                    double krainacena = kolichestvoGorivo * 2.21;
                    Console.WriteLine($"{krainacena:F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo >= 20 && kolichestvoGorivo <= 25)
                {
                    double krainacena = kolichestvoGorivo * 2.33;
                    Console.WriteLine($"{(krainacena - krainacena * 0.08):F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo > 25)
                {
                    double krainacena = kolichestvoGorivo * 2.33;
                    Console.WriteLine($"{(krainacena - krainacena * 0.10):F2} lv.");
                }
                else if (klubKarta == "No" && kolichestvoGorivo <20)
                {
                    double krainacena = kolichestvoGorivo * 2.33;
                    Console.WriteLine($"{krainacena:F2} lv.");
                }
            }

        }
    }
}