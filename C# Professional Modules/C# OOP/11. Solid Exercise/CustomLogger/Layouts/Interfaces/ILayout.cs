using CustomLogger.Models;

namespace CustomLogger.Layouts.Interfaces
{
    public interface ILayout
    {
        string Format(Message message);
    }
}
