using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            PrintMethodsByAuthor(typeof(StartUp));
        }
        public void PrintMethodsByAuthor(Type type)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                List<AuthorAttribute> attributes = method.GetCustomAttributes<AuthorAttribute>().ToList();
                if (attributes.Count > 0) 
                {
                    foreach (var attr in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {attr.Name}");
                    }
                }
            }
        }
    }
}
