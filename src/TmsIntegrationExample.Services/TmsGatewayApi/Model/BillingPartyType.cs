// <copyright file="BillingPartyType.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     BillingPartyType values
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    /// <summary>
    /// Enumerated BillingPartyType values.
    /// </summary>
    public enum BillingPartyType
    {
        /// <summary>
        /// Bill to the shipper
        /// </summary>
        SHIPPER = 1,

        /// <summary>
        /// Bill to the consignee
        /// </summary>
        CONSIGNEE = 2,

        /// <summary>
        /// Bill third party
        /// </summary>
        THIRD_PARTY = 3,
    }
}
