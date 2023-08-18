// <copyright file="HazmatProperties.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//      The representation for hazmat properties on a shipment unit.
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public class HazmatProperties
    {
        /// <summary>
        /// The hazmat UN number.
        /// </summary>
        public string UnNumber { get; set; }

        /// <summary>
        /// The hazmat package group.
        /// </summary>
        public string PackageGroup { get; set; }

        /// <summary>
        /// The hazmat class.
        /// </summary>
        public string Class { get; set; }
    }
}
