// <copyright file="Shipment.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//      The representation for a shipment resource.
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    using System;
    using System.Collections.Generic;

    public class Shipment
    {
        public Guid ShipmentId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? CarrierId { get; set; }

        /// <summary>
        /// The shipment name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The shipment bol/master bill number.
        /// </summary>
        public string BillNumber { get; set; }

        /// <summary>
        /// The shipment tracking number.
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The account number for the customer the shipment is being created.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// The Carrier's Standard Carrier Apha Code for freight shipments.
        /// </summary>
        public string CarrierScac { get; set; }

        /// <summary>
        /// The Carrier Name.
        /// </summary>
        public string CarrierName { get; set; }

        /// <summary>
        /// The current shipment situation.
        /// </summary>
        public ShipmentStatus ShipmentStatus { get; set; }

        /// <summary>
        /// Indicates if the shipment data is complete and finished.
        /// </summary>
        public bool IsComplete { get; set; }

        /// <summary>
        /// Indicates that the shipment needs to be dispatched.
        /// </summary>
        public bool Dispatch { get; set; }

        /// <summary>
        /// The mode of transportation.
        /// </summary>
        public Mode? Mode { get; set; }

        /// <summary>
        /// The requested equipment type for transporting a shipment.
        /// </summary>
        public EquipmentType? EquipmentType { get; set; }

        /// <summary>
        /// The requested service level for the shipment.
        /// </summary>
        public ServiceLevel? ServiceLevel { get; set; }

        /// <summary>
        /// The freight terms for the shipment.
        /// </summary>
        public FreightTerms? FreightTerms { get; set; }

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
        public BillingDetail BillingDetail { get; set; }

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
        ///  shipment documents.
        /// </summary>
        public Documents Documents { get; set; }

        /// <summary>
        /// The shipment request type.
        /// </summary>
        public RequestType? RequestType { get; set; }

        /// <summary>
        /// The booking options for this shipment.
        /// </summary>
        public BookingOptions BookingOptions { get; set; }
    }
}
