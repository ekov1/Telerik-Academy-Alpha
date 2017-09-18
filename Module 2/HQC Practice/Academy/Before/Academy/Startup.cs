using Academy.Core;
using Academy.Ninject;
using Ninject;

namespace Academy
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            // Singleton design pattern
            // Ensures that there is only one instance of Engine in existance
            var kernel = new StandardKernel(new AcademyModule());
            var engine = kernel.Get<Engine>();
            engine.Start();
        }
    }
}
