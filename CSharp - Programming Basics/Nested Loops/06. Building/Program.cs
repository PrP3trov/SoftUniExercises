using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int etaj = int.Parse(Console.ReadLine());
            int stai = int.Parse(Console.ReadLine());                      
                for (int i = etaj; i > 0; i--) // 6 puti
                {
                    if (etaj == 1)
                    {
                        for (int j = 0; j < stai; j++) //4
                        {

                            Console.Write($"L{i}{j} ");

                        }
                        Console.WriteLine();
                    }
                   else if (i == etaj)
                    {
                        for (int j = 0; j < stai; j++) // 4
                            Console.Write($"L{i}{j} ");
                        Console.WriteLine();
                    }
                    else if ( i % 2 == 0 )
                    {
                        for (int j = 0; j < stai; j++)
                        {
                           
                          
                                Console.Write($"O{i}{j} ");
                            

                        }
                        Console.WriteLine();

                    }
                    else if (i %2 != 0)
                    {
                        for (int j = 0; j < stai; j++) //4
                        {                      
                            
                              Console.Write($"A{i}{j} ");
                            
                        }
                        Console.WriteLine();
                    }
                
               
            }
        }
    }
}
