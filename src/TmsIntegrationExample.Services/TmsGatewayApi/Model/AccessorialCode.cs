// <copyright file="AccessorialCode.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Accessorial Code possible values
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    /// <summary>
    /// An enumeration of possible accessorial codes for customer requested accessorials. If anything other than a customer request item is put in this enumeration Joy will come after you with fire and fury.
    /// </summary>
    public enum AccessorialCode
    {
        /// <summary>
        /// The accessorial for airport pickup or delivery.
        /// </summary>
        AIR = 1,

        /// <summary>
        /// The accessorial for a pickup appointment.
        /// </summary>
        APPOINTMENT = 2,

        /// <summary>
        /// The accessorial for collecting payment on delivery.
        /// </summary>
        COLLECT_ON_DELIVERY = 3,

        /// <summary>
        /// The accessorial for tradeshow at pickup or delivery.
        /// </summary>
        TRADESHOW = 4,

        /// <summary>
        /// The accessorial for protection from freezing.
        /// </summary>
        PROTECT_FROM_FREEZE = 5,

        /// <summary>
        /// The accessorial for hazardous materials.
        /// </summary>
        HAZARDOUS_MATERIAL = 6,

        /// <summary>
        /// The accessorial for residential pickup or delivery.
        /// </summary>
        RESIDENTIAL = 7,

        /// <summary>
        /// The accessorial for notify of pickup or delivery.
        /// </summary>
        NOTIFY = 8,

        /// <summary>
        /// The accessorial for limited access pickup or delivery.
        /// </summary>
        LIMITED_ACCESS = 9,

        /// <summary>
        /// The accessorial for construction site pickup or delivery.
        /// </summary>
        CONSTRUCTION = 10,

        /// <summary>
        /// The accessorial for inside pickup or delivery.
        /// </summary>
        INSIDE = 11,

        /// <summary>
        /// The accessorial for liftgate required pickup or delivery.
        /// </summary>
        LIFTGATE = 12,

        /// <summary>
        /// The accessorial for marking or tagging a shipment.
        /// </summary>
        MARKING = 13,

        /// <summary>
        /// The accessorial for prepaying or adding.
        /// </summary>
        PREPAY = 14,

        /// <summary>
        /// The accessorial for sort segregate.
        /// </summary>
        SORT_SEGREGATE = 15,
    }
}
