// <copyright file="BookingOptions.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//      This is the model that represents booking options for the shipment.
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    using System;

    public class BookingOptions
    {
        /// <summary>
        /// The reason type if a rate was selected that wasn't the cheapest.
        /// </summary>
        public string SelectedReasonType { get; set; }

        /// <summary>
        /// The reason description if a rate was selcted that wasn't the cheapest.
        /// </summary>
        public string SelectedReasonDescription { get; set; }

        /// <summary>
        /// The requested service level for the shipment.
        /// </summary>
        public string ServiceLevel { get; set; }

        /// <summary>
        /// The identifier for the carrier being requested.
        /// </summary>
        public Carrier Carrier { get; set; }

        /// <summary>
        /// The rate id of the rate that should be used to book thet shipment.
        /// </summary>
        public Guid SelectedRateId { get; set; }

        /// <summary>
        /// Inidicates if this shipment should be auto-dispatched.
        /// </summary>
        public bool Dispatch { get; set; }
    }
}
