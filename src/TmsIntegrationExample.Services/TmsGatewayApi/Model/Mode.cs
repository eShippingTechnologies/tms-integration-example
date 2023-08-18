// <copyright file="Mode.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Supported modes
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public enum Mode
    {
        // THE ORDER MATTERS! These enums are relating to ints that are stored in our DB so how these map back from the DB to enums has been defined and reordering is not allowed. If you need to add a new state do it at the end please :)

        /// <summary>
        /// Less than full truckload
        /// </summary>
        LTL = 1,

        /// <summary>
        /// Full truckload
        /// </summary>
        FTL = 2,

        /// <summary>
        /// Transport by air
        /// </summary>
        AIR = 3,

        /// <summary>
        /// Expedited
        /// </summary>
        EXPEDITED = 4,

        /// <summary>
        /// Parcel
        /// </summary>
        PARCEL = 5,

        /// <summary>
        /// Full container load
        /// </summary>
        FCL = 6,

        /// <summary>
        /// Less than container load
        /// </summary>
        LCL = 7,

        /// <summary>
        /// Courier shipment
        /// </summary>
        COURIER = 8,
    }
}
