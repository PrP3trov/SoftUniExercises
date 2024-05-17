namespace CommandPattern.Core.Contracts
{
    public interface ICommand
    {
       public string Execute(string[] args);
    }
}
