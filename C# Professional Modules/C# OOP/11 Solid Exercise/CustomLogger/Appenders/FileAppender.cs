using CustomLogger.Appenders.Interfaces;
using CustomLogger.Layouts.Interfaces;
using CustomLogger.Models;

namespace CustomLogger.Appenders
{
    public class FileAppender : IAppender
    {
        private ILayout _layout;

        public FileAppender(ILayout layout)
        {
            _layout = layout;
        }
        public LogEntryLevel LogLevel { get; set; } = 0;


        public string FilePath { get; set; } 
            = $"..\\..\\..\\{DateTime.Now:yyyyMMddhhmmss}.txt";
        public void Append(Message message)
        {
            string formattedLogEntry = _layout.Format(message);
            try
            {
                File.AppendAllText(FilePath,formattedLogEntry + Environment.NewLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

