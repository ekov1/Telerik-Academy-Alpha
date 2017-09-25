using System;
using Traveller.Core.Contracts.ProviderContracts;

namespace Traveller.Core.Providers
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
