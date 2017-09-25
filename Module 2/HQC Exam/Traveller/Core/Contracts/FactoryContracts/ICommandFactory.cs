using Traveller.Commands.Contracts;

namespace Traveller.Core.Contracts.FactoryContracts
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName);
    }
}
