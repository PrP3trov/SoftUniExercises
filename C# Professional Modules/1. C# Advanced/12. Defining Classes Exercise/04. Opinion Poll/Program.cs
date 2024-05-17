using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
               people.Add(person);
            }
            var result = people.Where(p => p.Age > 30).OrderBy(p => p.Name);
            foreach (Person person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }

}