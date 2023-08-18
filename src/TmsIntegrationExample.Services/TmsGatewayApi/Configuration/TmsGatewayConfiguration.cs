// <copyright file="TmsGatewayConfiguration.cs" company="Engaged Technologies">
// Copyright (c) Engaged Technologies. All rights reserved.
// </copyright>
// <summary>
//     Configuration class for TMS Gateway API
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Configuration
{
    public class TmsGatewayConfiguration
    {
        public System.Uri BaseAddress { get; set; }
        public System.Uri LoginBaseAddress { get; set; }
        public string LoginSubPath { get; set; }
        public string AuthorizeSubPath { get; set; }
        public string TokenSubPath { get; set; }
        public string ShipmentsSubPath { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ClientId { get; set; }
        public string RedirectUri { get; set; }
        public string AccountNumber { get; set; }
    }
}
