// <copyright file="Unit.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//      The representation of a shipment handling unit
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public class Unit
    {
        /// <summary>
        /// The freight class of the unit.
        /// </summary>
        public string FreightClass { get; set; }

        /// <summary>
        /// The description of the unit.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of these units on this shipment.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The total weight of this unit.
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// The weight unit of measure for this unit.
        /// </summary>
        public string WeightUnitOfMeasure { get; set; }

        /// <summary>
        /// The packaging type of this unit.
        /// </summary>
        public string PackageType { get; set; }

        /// <summary>
        /// The pallet type of this unit.
        /// </summary>
        public string PalletType { get; set; }

        /// <summary>
        /// Indicates whether this unit is stackable.
        /// </summary>
        public bool IsStackable { get; set; }

        /// <summary>
        /// The hazmat specific properties on a unit. If any hazmat properties are set or the hazmat properties are not null then the shipment should be treated as hazmat.
        /// </summary>
        public HazmatProperties Hazmat { get; set; }

        /// <summary>
        /// The stated monetary value of this unit.
        /// </summary>
        public decimal? MonetaryValue { get; set; }

        /// <summary>
        /// The nfmc of the item. This field, if included, must not be empty and not exceed 50 alpha-numeric characters.
        /// </summary>
        public string Nmfc { get; set; }

        /// <summary>
        /// The sku of the item. This field, if included, must not be empty and not exceed 150 alpha-numeric characters.
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Flag for whether this is a new item or not.
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// The quanity of contains type on an item. This field is required when you include a contains description.
        /// </summary>
        public int? ContainsQuantity { get; set; }

        /// <summary>
        /// The desription of what is in the item.
        /// </summary>
        public string ContainsDescription { get; set; }

        /// <summary>
        /// The height of the item. This field, if included, must be a positive value with no more than 2 decimal places.
        /// </summary>
        public decimal? Height { get; set; }

        /// <summary>
        /// The width of the item. This field, if included, must be a positive value with no more than 2 decimal places.
        /// </summary>
        public decimal? Width { get; set; }

        /// <summary>
        /// The length of the item. This field, if included, must be a positive value with no more than 2 decimal places.
        /// </summary>
        public decimal? Length { get; set; }

        /// <summary>
        /// The dimensions unit of measure for this unit.
        /// </summary>
        public string DimensionsUnitOfMeasure { get; set; }
    }
}
