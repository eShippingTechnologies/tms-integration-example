// <copyright file="Accessorial.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Model for an Accessorial
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public class Accessorial
    {
        /// <summary>
        /// Gets or sets the accessorial code.
        /// </summary>
        /// <value>The accessorial code.</value>
        public AccessorialCode AccessorialCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the accessorial.
        /// </summary>
        /// <value>The type of the accessorial. i.e ORIGIN, DESINATION, SHIPMENT, PRODUCT.</value>
        public AccessorialType AccessorialType { get; set; }
    }
}
