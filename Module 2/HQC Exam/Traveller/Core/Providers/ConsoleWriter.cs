using System;
using Traveller.Core.Contracts.ProviderContracts;

namespace Traveller.Core.Providers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
