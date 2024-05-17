using CustomLogger.Appenders.Interfaces;
using CustomLogger.Loggers.Interfaces;
using CustomLogger.Models;

namespace CustomLogger.Loggers
{
    public class Logger : ILogger
    {
        private readonly ICollection<IAppender> _appenders = new List<IAppender>();

        public Logger(IAppender appender)
        {
            _appenders.Add(appender);
        }
        public void AddAppender (IAppender appender)
        {
            _appenders.Add(appender);
        }
        public void Info(DateTime dateTime, string logMessage)
        {
            Log(new Message(LogEntryLevel.Info, logMessage, dateTime));
        }
        public void Warning(DateTime dateTime, string logMessage)
        {
            Log(new Message(LogEntryLevel.Warning, logMessage, dateTime));
        }
        public void Error(DateTime dateTime, string logMessage)
        {
            Log(new Message(LogEntryLevel.Error, logMessage, dateTime));
        }
        public void Critical(DateTime dateTime, string logMessage)
        {
            Log(new Message(LogEntryLevel.Critical, logMessage, dateTime));
        }
        public void Fatal(DateTime dateTime, string logMessage)
        {
            Log(new Message(LogEntryLevel.Fatal, logMessage, dateTime));
        }
        private void Log(Message message)
        {
            foreach (var appender in _appenders)
            {
                if(message.LogEntryLevel >= appender.LogLevel)
                {
                    appender.Append(message);
                }
            }
        }
    }
}
