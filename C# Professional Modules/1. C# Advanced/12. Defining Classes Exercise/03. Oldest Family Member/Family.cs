namespace DefiningClasses
{
    public class Family
    {
        public List<Person> people = new();
        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            var maxAge = people.Max(p => p.Age);
            Person olderstPerson = people.FirstOrDefault(p => p.Age == maxAge);
            return olderstPerson;
        }
    }
}