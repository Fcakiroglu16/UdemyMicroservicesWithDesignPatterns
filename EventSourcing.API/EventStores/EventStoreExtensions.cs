using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSourcing.API.EventStores
{
    public static class EventStoreExtensions
    {
        public static void AddEventStore(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = EventStoreConnection.Create(connectionString: configuration.GetConnectionString("EventStore"));

            connection.ConnectAsync().Wait();

            services.AddSingleton(connection);

            using var logFactory = LoggerFactory.Create(builder =>
            {
                builder.SetMinimumLevel(LogLevel.Information);
                builder.AddConsole();
            });

            var logger = logFactory.CreateLogger("Startup");

            connection.Connected += (sender, args) =>
             {
                 logger.LogInformation("EventStore connection established");
             };

            connection.ErrorOccurred += (sender, args) =>
            {
                logger.LogError(args.Exception.Message);
            };
        }
    }
}