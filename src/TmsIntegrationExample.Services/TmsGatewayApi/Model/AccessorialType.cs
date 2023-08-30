// <copyright file="AccessorialType.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Accessorial type possible values
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    /// <summary>
    /// An enumeration of possible accessorial types.
    /// </summary>
    public enum AccessorialType
    {
        /// <summary>
        /// accessorial was set on the product.
        /// </summary>
        PRODUCT = 1,

        /// <summary>
        /// accessorial was set on the origin.
        /// </summary>
        ORIGIN = 2,

        /// <summary>
        /// accessorial was set on the destination.
        /// </summary>
        DESTINATION = 3,

        /// <summary>
        /// accessorial was set on the shipment overall.
        /// </summary>
        SHIPMENT = 4,
    }
}
