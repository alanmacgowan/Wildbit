using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageRouter.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MessageRoutingService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddTransient<IMessageRoutingService, MessageRouter.Routing.MessageRoutingService>();
                    services.AddHostedService<Worker>();
                });
    }
}
