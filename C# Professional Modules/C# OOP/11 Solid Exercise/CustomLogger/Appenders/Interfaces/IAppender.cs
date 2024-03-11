using CustomLogger.Models;

namespace CustomLogger.Appenders.Interfaces
{
    public interface IAppender
    {
        void Append(Message message);
        LogEntryLevel LogLevel { get; set; }
    }
}
