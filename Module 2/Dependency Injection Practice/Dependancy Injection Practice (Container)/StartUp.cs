using Dependancy_Injection_Practice__Container_.Ninject;
using Dependency_Injection_Practice;
using Ninject;

namespace Dependancy_Injection_Practice__Container_
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(new HelloWorldModule());
            var salutation = kernel.Get<Salutation>();
            salutation.Exclaim();
        }
    }
}
