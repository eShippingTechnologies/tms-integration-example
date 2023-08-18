// <copyright file="RequestType.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//    Shipment Request type.
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public enum RequestType
    {
        /// <summary>
        /// Request type is truckload
        /// </summary>
        TRUCKLOAD = 1,

        /// <summary>
        /// Request type is expedite
        /// </summary>
        EXPEDITE = 2,

        /// <summary>
        /// Request type is quote
        /// </summary>
        QUOTE_REQUESTED = 3,

        /// <summary>
        /// Request type is optimize
        /// </summary>
        OPTIMIZE = 4,
    }
}
