﻿using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale = new(6, 6);
            Console.WriteLine(scale.AreEqual());
        }
    }

}