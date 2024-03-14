namespace CustomLogger.Models
{
    public class Message
    {
        public Message(LogEntryLevel logEntryLevel, string logMessage, DateTime dateTime)
        {
            LogEntryLevel = logEntryLevel;
            LogMessage = logMessage;
            DateTime = dateTime;
        }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public LogEntryLevel LogEntryLevel { get; set; }
        public string LogMessage { get; set; }
    }
}
