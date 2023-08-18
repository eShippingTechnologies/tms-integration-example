// <copyright file="ServiceLevel.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     An enum of available service levels
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    /// <summary>
    /// An enumeration of possible service levels availible for a shipment.
    /// </summary>
    // THE ORDER MATTERS! These enums are relating to ints that are stored in our DB so how these map back from the DB to enums has been defined and reordering is not allowed.If you need to add a new state do it at the end please :)
    public enum ServiceLevel
    {
        /// <summary>
        /// Standard service level
        /// </summary>
        STANDARD = 0,

        /// <summary>
        /// service level for guarenteed by a time
        /// </summary>
        GUARANTEED = 1,

        /// <summary>
        /// service level for guarenteed by 1030 AM on the delivery date
        /// </summary>
        GUARANTEED_1030 = 2,

        /// <summary>
        /// service level for guarenteed by 1200 AM on the delivery date
        /// </summary>
        GUARANTEED_1200 = 3,

        /// <summary>
        /// service level for guarenteed by 0300 PM on the delivery date
        /// </summary>
        GUARANTEED_1500 = 4,

        /// <summary>
        /// service level for guarenteed by a time
        /// </summary>
        GUARANTEED_PM = 5,

        /// <summary>
        /// service level for guarenteed by a time within a day of shipping
        /// </summary>
        GUARANTEED_1_DAY = 6,

        /// <summary>
        /// service level for guarenteed by a time within 2 days of shipping
        /// </summary>
        GUARANTEED_2_DAY = 7,
    }
}
