using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Interpreters
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] elements = args.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
            string command = $"{elements[0]}Command";
            var commandArgs = elements.Skip(1).ToArray();

            var assembly = Assembly.GetEntryAssembly();
            var type = assembly.GetTypes().FirstOrDefault(t => t.Name == command);
            if (type == null) 
            {
                throw new ArgumentException("Invalid type!");
            }
            var instance = (ICommand)Activator.CreateInstance(type);
           return instance.Execute(commandArgs);
        }
    }
}
