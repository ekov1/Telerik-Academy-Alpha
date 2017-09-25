using System;
using System.Diagnostics;
using Traveller.Core.Contracts;

namespace Traveller.Core.Decorators
{
    public class EngineWithTimer : IEngine
    {
        private readonly IEngine engine;
        private Stopwatch stopwatch;

        public EngineWithTimer(IEngine engine)
        {
            this.engine = engine;
            this.stopwatch = new Stopwatch();
        }

        public void Start()
        {
            stopwatch.Start();
            Console.WriteLine("The Engine is starting...");
            engine.Start();
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"The Engine worked for {stopwatch.ElapsedMilliseconds} milliseconds.");
            //viktor said there is no need to decouple from this
        }
    }
}
