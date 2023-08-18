// <copyright file="MockProcessor.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     implementation class for processing Mock orders/shipments
// </summary>

namespace TmsIntegrationExample.Example
{
    using Microsoft.Extensions.Options;
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;
    using TmsIntegrationExample.Example.Transformers;
    using TmsIntegrationExample.Services.MockApi;
    using TmsIntegrationExample.Services.TmsGatewayApi;
    using TmsIntegrationExample.Services.TmsGatewayApi.Configuration;

    public class TmsIntegrationExampleProcessor : ITmsIntegrationExampleProcessor
    {
        private readonly ITmsGatewayClient tmsGatewayClient;
        private readonly IMockClient mockClient;
        private readonly TmsGatewayConfiguration tmsGatewayConfiguration;

        public TmsIntegrationExampleProcessor(
            ITmsGatewayClient tmsGatewayClient, 
            IMockClient mockClient,
            IOptions<TmsGatewayConfiguration> tmsGatewayConfiguration)
        {
            this.tmsGatewayConfiguration = tmsGatewayConfiguration.Value;
            this.tmsGatewayClient = tmsGatewayClient;
            this.mockClient = mockClient;
        }

        public async Task<int> ProcessAsync()
        {
            var ordersResult = await mockClient.GetOrdersAsync(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"MockApi\Orders.json"));

            var numberProcessed = 0;

            if (ordersResult != null)
            {
                foreach (var order in ordersResult)
                {
                    var sourceLocation = await mockClient.GetAddressByAddressIdAsync(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"MockApi\SourceLocation.json"));
                    var shipTo = new Services.MockApi.Model.Address();
                    if (order.ShipToId != null)
                    {
                        shipTo = await mockClient.GetAddressByAddressIdAsync(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"MockApi\ShipTo.json"));
                    }

                    var shipmentPost = new MockOrderToShipment().Transform(order, shipTo, sourceLocation, this.tmsGatewayConfiguration.AccountNumber);

                    await tmsGatewayClient.PostShipmentAsync(shipmentPost);

                    numberProcessed++;
                }
            }

            return numberProcessed;
        }
    }
}
