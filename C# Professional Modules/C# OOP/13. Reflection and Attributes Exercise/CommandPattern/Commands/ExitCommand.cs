using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern.Commands
{
    public class ExitCommand : ICommand
    {
        private const int exitcode = 0;
        public string Execute(string[] args)
        {
            Environment.Exit(exitcode);
            return null;
        }
    }
}
