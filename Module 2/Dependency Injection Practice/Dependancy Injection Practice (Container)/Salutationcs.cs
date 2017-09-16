using System;
using Dependancy_Injection_Practice__Container_;

namespace Dependency_Injection_Practice
{
    public class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer ?? throw new ArgumentException("Writer cannot be null!");
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI!");
        }
    }
}