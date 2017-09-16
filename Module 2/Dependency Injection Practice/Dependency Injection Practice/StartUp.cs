using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Practice
{
    public class StartUp
    {
        public static void Main()
        {
            IMessageWriter writer = new ConsoleMessageWrite();
            var salutation = new Salutation(writer);
            salutation.Exclaim();
        }
    }
}
