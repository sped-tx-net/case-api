using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Ims.Case
{
    public static class ServiceManager
    {
        private static IServiceCollection _services;

        public static IServiceCollection Services
        {
            get
            {
                return _services ??= new ServiceCollection();
            }
            set
            {
                _services = value;
            }
        }


        public static TService GetService<TService>()
        {
            return Services.BuildServiceProvider().GetService<TService>();
        }
    }
}
