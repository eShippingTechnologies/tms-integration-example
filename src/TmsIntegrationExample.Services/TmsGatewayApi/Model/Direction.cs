// <copyright file="Direction.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Direction values
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public enum Direction
    {
        /// <summary>
        /// Inbound.
        /// </summary>
        INBOUND = 1,

        /// <summary>
        /// Outbound.
        /// </summary>
        OUTBOUND = 2,

        /// <summary>
        /// Inbound Transfer.
        /// </summary>
        INBOUND_TRANSFER = 3,

        /// <summary>
        /// Outbound Transfer.
        /// </summary>
        OUTBOUND_TRANSFER = 4,

        /// <summary>
        /// Transfer.
        /// </summary>
        TRANSFER = 5,

        /// <summary>
        /// Other.
        /// </summary>
        OTHER = 6,
    }
}
