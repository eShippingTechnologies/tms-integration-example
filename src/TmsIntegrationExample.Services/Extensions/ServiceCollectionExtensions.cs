// <copyright file="ServiceCollectionExtensions.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Extensions for IServiceCollection
// </summary>

namespace TmsIntegrationExample.Services.Extensions
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using TmsIntegrationExample.Services.EpicorApi;
    using TmsIntegrationExample.Services.MockApi;
    using TmsIntegrationExample.Services.TmsGatewayApi;
    using TmsIntegrationExample.Services.TmsGatewayApi.Configuration;

    public static class ServiceCollectionExtensions
    {
        public static void AddMockClient(this IServiceCollection services, IConfiguration config)
        {
            services.TryAddScoped<IMockClient, MockClient>();
        }

        public static void AddTmsGatewayClient(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<TmsGatewayConfiguration>(config);
            services.TryAddScoped<ITmsGatewayClient, TmsGatewayClient>();
        }

        public static IServiceCollection AddJsonSerializerOptions(this IServiceCollection collection)
        {
            collection.TryAddSingleton(provider =>
            {
                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter() },
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true,
                };

                return options;
            });

            return collection;
        }
    }
}
