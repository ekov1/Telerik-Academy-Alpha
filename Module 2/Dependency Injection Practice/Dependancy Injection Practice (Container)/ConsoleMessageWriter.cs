using System;

namespace Dependancy_Injection_Practice__Container_
{
    public class ConsoleMessageWrite : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
