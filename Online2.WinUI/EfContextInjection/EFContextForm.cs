using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Online2.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.WinUI.EfContextInjection
{
    public static class EFContextForm
    {
        private static  IServiceProvider _serviceProvider;

        private static IHostBuilder CreateHostBuilder<T>() where T : Form
        {
            var result = Host.CreateDefaultBuilder()
                             .ConfigureServices((services) =>
                             {
                                 services.AddScopeBLL();
                                 services.AddTransient<T>();
                             });
            return result;
        }

        public static Form ConfigureServices<T>() where T : Form
        {
            var host = CreateHostBuilder<T>().Build();
            _serviceProvider = host.Services;
            return _serviceProvider.GetRequiredService<T>();
        }


    }    
}
