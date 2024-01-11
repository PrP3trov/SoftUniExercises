using System;
using System.ComponentModel;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nachalo = int.Parse(Console.ReadLine());
            int krai = int.Parse(Console.ReadLine());
            int magiqchislo = int.Parse(Console.ReadLine());
            int kombinaciq = 0;
            int nomer = 0;
            int result = 0;
            int n1 = 0, n2 = 0;
            bool flag = false;
            for (int a = nachalo; a <= krai; a++)
            {
                for (int b = nachalo; b <= krai; b++)
                {
                     result = a + b;
                    kombinaciq++;

                    if (result == magiqchislo)
                    {
                        nomer = kombinaciq;
                        n1 = a;
                        n2 = b;
                        Console.WriteLine($"Combination N:{nomer} ({n1} + {n2} = {magiqchislo})");
                        flag = true;
                        break;
                    }                   
                } if (flag)  break; 
            }
           if (result != magiqchislo) Console.WriteLine($"{kombinaciq} combinations - neither equals {magiqchislo}");
        }
    }
}
