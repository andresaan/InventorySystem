using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using InventoryTool.Views;
using InventoryTool.Models;
using InventoryTool.Presenters;
using Infrastructure.Repositories;
using Infrastructure.Interfaces;

namespace InventoryTool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var serviceProvider = serviceScope.ServiceProvider;
                Program.ServiceProvider = serviceProvider;

                var mainPresenter = serviceProvider.GetRequiredService<MainPresenter>();

                Application.Run(new ApplicationContext()
                {
                    Tag = mainPresenter,
                });
            }
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IMainModel, MainModel>();
                    services.AddTransient<IMainView, MainView>();
                    services.AddTransient<MainPresenter>();

                    services.AddTransient<IPartService, PartService>();
                    services.AddTransient<IProductService, ProductService>();
                    services.AddTransient<IValidatorService, ValidatorService>();

                    services.AddTransient<IPartRepository, PartRepository>();
                    services.AddTransient<IProductRepository, ProductRepository>();
                    services.AddTransient<IProductPartRepository, ProductPartRepository>();

                    services.AddTransient<IPartModel, PartModel>();
                    services.AddTransient<IPartView, PartView>();
                    services.AddTransient<IProductModel, ProductModel>();
                    services.AddTransient<IProductView, ProductView>();
                });
        }
    }



}
