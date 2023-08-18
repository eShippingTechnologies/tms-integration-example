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
    // THE ORDER MATTERS! These enums are relating to ints that are stored in our DB so how these map back from the DB to enums has been defined and reordering is not allowed.If you need to add a new state do it at the end please :)
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
