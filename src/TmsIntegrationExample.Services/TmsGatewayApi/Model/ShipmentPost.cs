// <copyright file="ShipmentPost.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//      The representation for a POST shipment resource.
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    using System.Collections.Generic;

    public class ShipmentPost
    {
        /// <summary>
        /// The account number for the customer the shipment is being created.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// The Carrier's Standard Carrier Apha Code for freight shipments.
        /// </summary>
        public string CarrierScac { get; set; }

        /// <summary>
        /// Indicates if the shipment data is complete and finished.
        /// </summary>
        public bool IsComplete { get; set; }

        /// <summary>
        /// The desired shipment status of the shipment being created.
        /// </summary>
        public string ShipmentStatus { get; set; }

        /// <summary>
        /// Indicates that the shipment needs to be dispatched.
        /// </summary>
        public bool Dispatch { get; set; }

        /// <summary>
        /// The mode of transportation.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// The requested equipment type for transporting a shipment.
        /// </summary>
        public string EquipmentType { get; set; }

        /// <summary>
        /// The requested service level for the shipment.
        /// </summary>
        public string ServiceLevel { get; set; }

        /// <summary>
        /// The requested pickup date the customer would prefer in ISO-8601 standard date format.
        /// </summary>
        public string RequestedPickupDate { get; set; }

        /// <summary>
        /// The requested delivery date in ISO-8601 standard date format.
        /// </summary>
        public string RequestedDeliveryDate { get; set; }

        /// <summary>
        /// The shipment origin stop.
        /// </summary>
        public Stop Origin { get; set; }

        /// <summary>
        /// The shipment destination stop.
        /// </summary>
        public Stop Destination { get; set; }

        /// <summary>
        /// The hazmat properties.
        /// </summary>
        public ShipmentHazmatProperties Hazmat { get; set; }

        /// <summary>
        /// Billing details.  Required when FreightTerms are 3rd Party (T_THIRD_PARTY).
        /// </summary>
        public BillingDetailPost BillingDetail { get; set; }

        /// <summary>
        ///  Collection of handling Units.
        /// </summary>
        public ICollection<Unit> Units { get; set; }

        /// <summary>
        ///  Collection of accessorials.
        /// </summary>
        public ICollection<Accessorial> Accessorials { get; set; }

        /// <summary>
        ///  Collection of shipment reference numbers.
        /// </summary>
        public ICollection<ReferenceNumber> ReferenceNumbers { get; set; }

        /// <summary>
        /// The booking options for this shipment.
        /// </summary>
        public BookingOptions BookingOptions { get; set; }
    }
}
