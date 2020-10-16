using Destiny_2_Interface.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destiny_2_Interface.src.Utility
{
    public static class EnumConverter
    {
        public static BungieMembershipType GetBungieMembershipTypeFromString(string platform)
        {
            platform = platform.ToLower();
            switch (platform)
            {
                case "steam":
                    return BungieMembershipType.TigerSteam;
                case "xbox":
                    return BungieMembershipType.TigerXbox;
                case "playstation":
                    return BungieMembershipType.TigerPsn;
                case "psn":
                    return BungieMembershipType.TigerPsn;
                case "blizzard":
                    return BungieMembershipType.TigerBlizzard;
                case "stadia":
                    return BungieMembershipType.TigerStadia;
                case "demon":
                    return BungieMembershipType.TigerDemon;
                default:
                    return BungieMembershipType.None;
            }
        }
    }
}
