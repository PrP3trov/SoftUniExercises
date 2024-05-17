using CustomLogger.Appenders.Interfaces;
using CustomLogger.Layouts.Interfaces;
using CustomLogger.Models;
using System.Reflection.Metadata.Ecma335;

namespace CustomLogger.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private ILayout _layout;

        public ConsoleAppender(ILayout layout)
        {
            _layout = layout;
        }

        public LogEntryLevel LogLevel { get; set; } = 0;

        public void Append(Message message)
        {
            Console.WriteLine(_layout.Format(message));
        }
    }
}
