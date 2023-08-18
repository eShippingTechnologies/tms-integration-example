// <copyright file="BillingDetail.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//      Represents the Billing Detail on a shipment.
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public class BillingDetail
    {
        /// <summary>
        /// The billing type. Possible values are BILLING_STANDARD, BILLING_COLLECT, or BILLING_ALT_THIRD_PARTY.
        /// </summary>
        public BillingType? BillingType { get; set; }

        /// <summary>
        /// The type of the billing party. Possible values are SHIPPER, CONSIGNEE, or THIRD_PARTY.
        /// </summary>
        public BillingPartyType? BillingPartyType { get; set; }

        /// <summary>
        /// The party an invoice for this shipment should be billed to.
        /// </summary>
        public string BillingParty { get; set; }

        /// <summary>
        /// Line 1 of the billing address.
        /// </summary>
        public string BillingAddress1 { get; set; }

        /// <summary>
        /// Line 2 of the billing address.
        /// </summary>
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// The city of the billing address.
        /// </summary>
        public string BillingCity { get; set; }

        /// <summary>
        /// The ISO 3166 code which represents the state for the billing address.
        /// </summary>
        public string BillingStateCode { get; set; }

        /// <summary>
        /// The postal code of the billing address.
        /// </summary>
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// The ISO 3166 code which represents the country for the billing address.
        /// </summary>
        public string BillingCountryCode { get; set; }

        /// <summary>
        /// The direction of the shipment for billing purposes.
        /// </summary>
        public Direction? Direction { get; set; }
    }
}
