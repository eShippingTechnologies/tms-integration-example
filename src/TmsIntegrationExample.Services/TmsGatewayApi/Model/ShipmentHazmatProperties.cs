// <copyright file="ShipmentHazmatProperties.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//      Hazmat properties on a shipment
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    /// <summary>
    /// The shipment hazmat properties.
    /// </summary>
    public class ShipmentHazmatProperties
    {
        /// <summary>
        /// The hazmat contact name.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// The hazmat contact phone.
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// The hazmat contract number.
        /// </summary>
        public string ContractNumber { get; set; }
    }
}
