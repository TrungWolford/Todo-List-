//using EmailReminderService;

//var builder = Host.CreateApplicationBuilder(args);
//builder.Services.AddHostedService<Worker>();


//var host = builder.Build();
//host.Run();
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace EmailReminderService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<EmailService>();
                    services.AddSingleton<ReminderService>();
                    services.AddHostedService<Worker>();
                });
    }
}
