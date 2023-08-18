// <copyright file="Carrier.cs" company="Engaged Technologies">
//     Copyright (c) Engaged Technologies. All rights reserved.
// </copyright>
// <summary>
//     Carrier model
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public class Carrier
    {
        /// <summary>
        /// Type of Carrier Identifier.
        /// </summary>
        public string IdentifierType { get; set; }

        /// <summary>
        /// Identifier Value.  i.e. SCAC value.
        /// </summary>
        public string Identifier { get; set; }
    }
}
