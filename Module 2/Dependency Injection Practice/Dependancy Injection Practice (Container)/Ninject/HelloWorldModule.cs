using Dependency_Injection_Practice;
using Ninject.Modules;

namespace Dependancy_Injection_Practice__Container_.Ninject
{
    public class HelloWorldModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMessageWriter>().To<ConsoleMessageWrite>();
            this.Bind<Salutation>().ToSelf();
        }
    }
}
