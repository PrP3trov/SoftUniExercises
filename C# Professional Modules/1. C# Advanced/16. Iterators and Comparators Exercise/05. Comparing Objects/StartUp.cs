namespace _05._Comparing_Objects
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] personProperties = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = personProperties[0],
                    Age = int.Parse(personProperties[1]),
                    Town = personProperties[2]  
                };
                people.Add(person);
            }
            int referenceIndex = int.Parse(Console.ReadLine()) -1;
            Person referencePerson = people[referenceIndex];
            int equalCount = 0;
            int differentCount = 0;
            foreach (var item in people)
            {
                if (item.CompareTo(referencePerson) == 0)
                {
                    equalCount++;
                }
                else
                {
                    differentCount++;
                }
            }
            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {differentCount} {people.Count}");
            }
        }
    }
}