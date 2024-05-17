using CustomLogger.Appenders;
using CustomLogger.Appenders.Interfaces;
using CustomLogger.Layouts;
using CustomLogger.Layouts.Interfaces;
using CustomLogger.Loggers;
using CustomLogger.Loggers.Interfaces;
using CustomLogger.Models;

namespace _1._Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();
            ILayout xmlLayout = new XmlLayout();

            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            IAppender fileAppender = new FileAppender(xmlLayout);

            consoleAppender.LogLevel = LogEntryLevel.Error;

            ILogger logger = new Logger(fileAppender);
            logger.AddAppender(consoleAppender);

            logger.Info(DateTime.Now, "Everything seems fine");
            logger.Warning(DateTime.Now, "Warning: ping is too high - disconnect imminent");
            logger.Error(DateTime.Now, "Error parsing request");
            logger.Critical(DateTime.Now, "No connection string found in App.config");
            logger.Fatal(DateTime.Now, "mscorlib.dll does not respond");
        }
    }
}