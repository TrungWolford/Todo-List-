using EmailReminderService;
using GUI.Components;
using GUI.Panel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Tạo Host để chạy Worker Service và GUI cùng lúc
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Đăng ký các dịch vụ của EmailReminderService
                    services.AddSingleton<EmailService>();
                    services.AddSingleton<ReminderService>();
                    services.AddHostedService<Worker>();
                })
                .Build();

            // Chạy GUI song song với Worker Service
            ApplicationConfiguration.Initialize();

            // Chạy giao diện Login Form
            var loginForm = new Login();

            // Chạy host và form cùng lúc
            Task.Run(() => host.RunAsync());
            Application.Run(loginForm);
            //Application.Run(new Login());
            
        }
    }
}