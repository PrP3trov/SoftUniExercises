using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double duljinaCM = double.Parse(Console.ReadLine());
            double shirinaCM = double.Parse(Console.ReadLine());
            double visochinaCM = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double obemAkvarium = duljinaCM * shirinaCM * visochinaCM;
            double obemVLitri = obemAkvarium / 1000;
            double prostranstvo = procent / 100;
            double nujniLitri = obemVLitri * (1 - prostranstvo);
            Console.WriteLine(nujniLitri);
        }
    }
}