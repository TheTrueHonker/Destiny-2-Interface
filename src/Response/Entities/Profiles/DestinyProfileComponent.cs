using Destiny_2_Interface.Response.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destiny_2_Interface.Response.Destiny.Entities.Profiles
{
    public class DestinyProfileComponent
    {
        public UserInfoCard UserInfo { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public int VersionsOwned { get; set; }
        public long[] CharacterIds { get; set; }
        public uint[] SeasonHashes { get; set; }
        public long CurrentSeasonHash { get; set; }
        public int CurrentSeasonRewardPowerCap { get; set; }
    }
}
