using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using venta_semilla_de_trigo.Views;

namespace venta_semilla_de_trigo
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
            ApplicationConfiguration.Initialize();
            
            var host = CreateHostBuilder().Build();
            var formService = host.Services.GetService<Home>();

            Application.Run(formService!);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.AddTransient<Home>();
                services.AddTransient<Stadistics>();
                });
    }
}