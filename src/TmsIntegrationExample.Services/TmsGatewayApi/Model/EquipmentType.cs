// <copyright file="EquipmentType.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Equipment types
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi.Model
{
    public enum EquipmentType
    {
        /// <summary>
        /// Dry van LTL Common Carrier
        /// </summary>
        LTL_DRY_VAN = 1,

        /// <summary>
        /// Flat bed
        /// </summary>
        FTL_FLAT_BED = 2,

        /// <summary>
        /// Step deck
        /// </summary>
        FTL_STEP_DECK = 3,

        /// <summary>
        /// Removable gooseneck
        /// </summary>
        FTL_REMOVABLE_GOOSENECK = 4,

        /// <summary>
        /// Hot shot
        /// </summary>
        FTL_HOT_SHOT = 5,

        /// <summary>
        /// Reefer
        /// </summary>
        FTL_REEFER = 6,

        /// <summary>
        /// Conestoga
        /// </summary>
        FTL_CONESTOGA = 7,

        /// <summary>
        /// Box truck
        /// </summary>
        FTL_BOX_TRUCK = 8,

        /// <summary>
        /// Dry van FTL
        /// </summary>
        FTL_DRY_VAN = 9,

        /// <summary>
        /// Van with Hazmat Certification
        /// </summary>
        FTL_VAN_WITH_HAZMAT = 10,

        /// <summary>
        /// Van with Tanker Endorsement
        /// </summary>
        FTL_VAN_WITH_TANKER = 11,

        /// <summary>
        /// Van with Tanker Endorsement and Hazmat Certification
        /// </summary>
        FTL_VAN_WITH_TANKER_AND_HAZMAT = 12,
    }
}
