// <copyright file="ReferenceNumber.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Reference number on a shipment
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public class ReferenceNumber
    {
        /// <summary>
        /// The type of the reference number.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value of the reference number. This field is required and may not exceed 100 characters.
        /// </summary>
        public string Value { get; set; }
    }
}
