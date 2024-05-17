using System.Reflection.Metadata.Ecma335;
using System.Threading;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private const int minAge = 12;
        private const int maxAge = 90;
        [MyRequired]
        public string FullName { get; set; }
        [MyRange(minAge,maxAge)]
        public int Age { get; set; }
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}
