using CustomLogger.Layouts.Interfaces;
using CustomLogger.Models;

namespace CustomLogger.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format(Message message)
        {
            return $"{message.DateTime} - {message.LogEntryLevel} - {message.LogMessage}";
        }
    }
}
