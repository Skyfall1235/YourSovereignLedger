using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using Photino.Blazor;
using System;
using YourSovereignLedger.Services;

namespace YourSovereignLedger
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var appBuilder = PhotinoBlazorAppBuilder.CreateDefault(args);

            appBuilder.Services
                .AddFluentUIComponents()
                .AddLogging();

            // register root component and selector
            appBuilder.RootComponents.Add<App>("app");
            //services(come back with interfaces)
            appBuilder.Services.AddSingleton<InvoiceGenerationService>();
            appBuilder.Services.AddSingleton<MetricsService>();
            appBuilder.Services.AddSingleton<OrderManagementService>();
            appBuilder.Services.AddSingleton<PrivacyStateService>();

            var app = appBuilder.Build();

            // customize window
            app.MainWindow
                .SetIconFile("favicon.ico")
                .SetTitle("Your Sovereign Ledger");

            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
                app.MainWindow.ShowMessage("Fatal exception", error.ExceptionObject.ToString());
            };

            app.Run();
        }
    }
}