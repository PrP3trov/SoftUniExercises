using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brtopki = int.Parse(Console.ReadLine());
            int tochki = 0, brRed = 0, brOrange = 0, brYellow = 0, brWhite = 0, brOther = 0, DevidesFromBlack = 0;
            for (int i = 0; i < brtopki; i++)
            {
                string topka = Console.ReadLine();              
                switch(topka)
                {
                    case "white": tochki += 20;
                       brWhite++;
                        break;
                    case "black":
                        tochki /= 2;
                        DevidesFromBlack++;
                        break;
                    case "yellow":
                        tochki += 15;
                        brYellow++;
                        break;
                    case "orange":
                        tochki += 10;
                        brOrange++;
                        break;
                    case "red":
                        tochki += 5;
                        brRed++;
                        break;
                    default: brOther++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {tochki}");
            Console.WriteLine($"Red balls: {brRed}");
            Console.WriteLine($"Orange balls: {brOrange}");
            Console.WriteLine($"Yellow balls: {brYellow}");
            Console.WriteLine($"White balls: {brWhite}");
            Console.WriteLine($"Other colors picked: {brOther}");
            Console.WriteLine($"Divides from black balls: {DevidesFromBlack}");

        }
    }
}
