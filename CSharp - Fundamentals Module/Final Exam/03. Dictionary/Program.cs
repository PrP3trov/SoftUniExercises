using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string[] wordDefinitions = Console.ReadLine().Split(" | ");
        string[] Test = Console.ReadLine().Split(" | ");
        string command = Console.ReadLine();


        var dictionary = new Dictionary<string, List<string>>();


        foreach (string wordAndDefiniton in wordDefinitions)
        {
            string[] parts = wordAndDefiniton.Split(": ");
            string word = parts[0];
            string definition = parts[1];

            if (!dictionary.ContainsKey(word))
            {
                dictionary[word] = new List<string>();
            }

            dictionary[word].Add(definition);
        }


        if (command == "Test")
        {

            foreach (string word in Test)
            {
                if (dictionary.ContainsKey(word))
                {
                    Console.WriteLine($"{word}:");
                    foreach (var definition in dictionary[word])
                    {
                        Console.WriteLine($"-{definition}");
                    }
                }
            }
        }
        else if (command == "Hand Over")
        {

            foreach (var word in dictionary.Keys)
            {
                Console.Write($"{word} ");
            }
        }
    }
}
