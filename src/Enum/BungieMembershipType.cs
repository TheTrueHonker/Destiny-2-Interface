﻿using System.ComponentModel;

namespace Destiny_2_Interface.Enum
{
    public enum BungieMembershipType
    {
        [Description("None")]
        None = 0,
        [Description("Xbox")]
        TigerXbox = 1,
        [Description("PSN")]
        TigerPsn = 2,
        [Description("Steam")]
        TigerSteam = 3,
        [Description("Battle.NET")]
        TigerBlizzard = 4,
        [Description("Stadia")]
        TigerStadia = 5,
        [Description("Demon")]
        TigerDemon = 10,
        [Description("Bungie")]
        BungieNext = 254,
        [Description("All")]
        All = -1,
    }
}
