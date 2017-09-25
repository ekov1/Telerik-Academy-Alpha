using Ninject;
using Traveller.Core.Contracts;
using Traveller.Core.Decorators;
using Traveller.Ninject;

namespace Traveller
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(new TravellerModule());

            var engine = kernel.Get<IEngine>();
            var engineWithTimer = new EngineWithTimer(engine);
            engineWithTimer.Start();
        }
    }
}
