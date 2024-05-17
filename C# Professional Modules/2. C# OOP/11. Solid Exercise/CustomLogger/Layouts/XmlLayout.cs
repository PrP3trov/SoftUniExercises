using CustomLogger.Layouts.Interfaces;
using CustomLogger.Models;
using System.Xml.Linq;

namespace CustomLogger.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format(Message message)
        {
            XElement logEntry = new XElement("log",
                new XElement("date", message.DateTime),
                new XElement("level", message.LogEntryLevel),
                new XElement("message", message.LogMessage));
            return logEntry.ToString();
        }
    }
}
