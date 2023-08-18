// <copyright file="BillingType.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     BillingType values
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    /// <summary>
    /// Enumerated BillingType values.
    /// </summary>
    public enum BillingType
    {
        /// <summary>
        /// Bill is prepaid
        /// </summary>
        BILLING_STANDARD = 1,

        /// <summary>
        /// Payment needs to be collected
        /// </summary>
        BILLING_COLLECT = 2,

        /// <summary>
        /// Payment will be handled by a third party
        /// </summary>
        BILLING_ALT_THIRD_PARTY = 3,

        /// <summary>
        /// Drop Shipment
        /// </summary>
        DROP_SHIP = 4,
    }
}
