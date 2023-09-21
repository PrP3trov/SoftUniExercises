using System;
using System.Runtime.CompilerServices;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mesec = Console.ReadLine();
            int noshtuvki = int.Parse(Console.ReadLine());
            double studiocena = 0;
            double apartamentcena = 0;
            switch(mesec)
            {
                case "May":
                case "October":
                    studiocena = 50;
                    apartamentcena = 65;
                    if (noshtuvki >7 && noshtuvki <14) { studiocena = (studiocena - studiocena * 0.05) * noshtuvki; apartamentcena = apartamentcena * noshtuvki;}
                    else if (noshtuvki >14) { studiocena = (studiocena - studiocena * 0.30) * noshtuvki; apartamentcena = (apartamentcena - apartamentcena * 0.10) * noshtuvki; }
                    else if (noshtuvki <= 7) { studiocena = studiocena * noshtuvki;apartamentcena = apartamentcena * noshtuvki; }
                    break;
                case "June":
                case "September":
                    studiocena = 75.20;
                    apartamentcena = 68.70;
                    if (noshtuvki > 14) { studiocena = (studiocena - studiocena * 0.20) * noshtuvki; apartamentcena = (apartamentcena - apartamentcena * 0.10) * noshtuvki;}
                    else { studiocena = studiocena * noshtuvki; apartamentcena = apartamentcena * noshtuvki; }
                    break;
                case "July":
                case "August":
                    studiocena = 76;
                    apartamentcena = 77;
                    if (noshtuvki > 14) { studiocena = studiocena * noshtuvki; apartamentcena = (apartamentcena - apartamentcena * 0.10) * noshtuvki;}
                    else { apartamentcena = apartamentcena * noshtuvki; studiocena = studiocena * noshtuvki ; }
                    break;

            }
            Console.WriteLine($"Apartment: {apartamentcena:F2} lv.");
            Console.WriteLine($"Studio: {studiocena:F2} lv.");
        }
    }
}
