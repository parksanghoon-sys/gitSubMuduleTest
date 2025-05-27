using CoreMvvmLib.Core.IOC;
using CoreMvvmLib.WPF.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfSubModdule
{
    internal class App : CoreMvvmApp
    {
        protected override void ConfigureServiceCollection(IServiceCollection services)
        {
            base.ConfigureServiceCollection(services);
        }
    }
}
