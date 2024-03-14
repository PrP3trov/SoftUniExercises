using CustomLogger.Appenders.Interfaces;

namespace CustomLogger.Loggers.Interfaces
{
    public interface ILogger
    {
        public void Info(DateTime dateTime, string logMessage);
        public void Warning(DateTime dateTime, string logMessage);
        public void Error(DateTime dateTime, string logMessage);
        public void Critical(DateTime dateTime, string logMessage);
        public void Fatal(DateTime dateTime, string logMessage);
        public void AddAppender(IAppender appender);

    }
}
