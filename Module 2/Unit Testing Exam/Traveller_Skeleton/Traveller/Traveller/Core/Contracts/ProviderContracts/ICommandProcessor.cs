namespace Traveller.Commands.Contracts
{
    public interface ICommandProcessor
    {
        string ProcessCommand(string commandAsString);
    }
}
