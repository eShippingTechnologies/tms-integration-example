// <copyright file="ShipmentStatus.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Shipment status.
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public enum ShipmentStatus
    {
        /// <summary>
        /// Shipment has not yet been booked, and is in an incomplete status
        /// </summary>
        BUILDING = 1,

        /// <summary>
        /// Shipment has been booked
        /// </summary>
        BOOKED = 2,

        /// <summary>
        /// Shipment has been canceled
        /// </summary>
        CANCELED = 3,

        /// <summary>
        /// Shimpent has been offered to carriers for auction and has not yet been booked
        /// </summary>
        OFFERED = 4,

        /// <summary>
        /// Shipment has been requested
        /// </summary>
        REQUESTED = 5,
    }
}
