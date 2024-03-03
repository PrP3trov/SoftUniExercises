using BorderControl.Models.Interfaces;

namespace BorderControl.Models
{
    public class Citizen : BaseEntity
    {
        public Citizen(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; private set; }

    }
}
