// <copyright file="Stop.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     The model that represents a shipment stop (origin, destination, etc.)
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    using System.Collections.Generic;

    public class Stop
    {
        /// <summary>
        /// Special instructions for a stop.
        /// </summary>
        public string SpecialInstructions { get; set; }

        /// <summary>
        /// A flag that indicates if an email notification should be sent.
        /// </summary>
        public bool SendEmail { get; set; }

        /// <summary>
        /// The location direction type for an address for determining direction of the shipment. Possible values are MY_LOCATION, MY_OTHER_LOCATION or THIRD_PARTY.
        /// </summary>
        public string LocationDirectionType { get; set; }

        /// <summary>
        /// The address name. This field, if included, must have at least 1 alpha-numeric character and not exceed 100 alpha-numeric characters.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Line one of the address. This field, if included, must have at least 1 alpha-numeric character and not exceed 50 alpha-numeric characters.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Line two of the address. This field, if included, may not exceed 50 alpha-numeric characters.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// The city of the address. This field, if included, must have at least 1 alpha-numeric character and not exceed 50 alpha-numeric characters.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The ISO 3166 code which represents the state for the address. This field, if included, must be between 1 and 3 alphanumberic characters.
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// The postal code of the address. This field, if included, must have at least 1 alpha-numeric character and not exceed 20 alpha-numeric characters.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The ISO 3166 code which represents the country for the address. This field, if included, must be 2 letters.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// The opening time in 24 hour HH:MM format.
        /// </summary>
        public string OpenTime { get; set; }

        /// <summary>
        /// The closing time in 24 hour HH:MM format.
        /// </summary>
        public string CloseTime { get; set; }

        /// <summary>
        /// The contact name of the address. This field, if included, must have at least 1 alpha-numeric character and not exceed 100 alpha-numeric characters.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// The contact phone of the address. This field, if included, must be a 10 digit numeric phone number.
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// The contact fax of the address. This field, if included, must be a 10 digit numeric phone number.
        /// </summary>
        public string ContactFax { get; set; }

        /// <summary>
        /// The contact email addresses. This field, if included, must be a valid email(s) following the standards in RFC 2821.
        /// </summary>
        public List<string> ContactEmails { get; set; }
    }
}
