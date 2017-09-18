using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Core;
using Academy.Core.Contracts;
using Ninject;
using Ninject.Modules;

namespace Academy.Ninject
{
    public class AcademyModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEngine>().To<Engine>().InSingletonScope();
        }
    }
}
