using System;
using ConsoleApp6.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp6
{
    class Program
    {
        private static ServiceProvider _serviceProvider;

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<TruckTest>();
            services.AddTransient<ITruck, ScaniaTruck>();
            services.AddTransient<IBilRadio, Leverantor1Radio>();
            _serviceProvider = services.BuildServiceProvider(true);
        }

        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<TruckTest>().Run();
            DisposeServices();
        }



        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
