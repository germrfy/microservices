using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SearchDataService.Process;
using SearchDataService.Process.Design;

namespace SearchDataService
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
                    services.AddSingleton<IProcessorFactory, ProcessorFactory>();
                    services.AddHostedService<Worker>();
                });
    }
}
