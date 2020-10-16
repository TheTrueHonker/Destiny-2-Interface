using Destiny_2_Interface.Enum;
using System;

namespace Destiny_2_Interface.Response.User
{
    public class GeneralUser
    {
        public long MembershipId { get; set; }
        public string UniqueName { get; set; }
        public string NormalizedName { get; set; }
        public string DisplayName { get; set; }
        public int ProfilePicture { get; set; }
        public int ProfileTheme { get; set; }
        public int UserTitle { get; set; }
        public long SuccessMessageFlags { get; set; }
        public bool IsDeleted { get; set; }
        public string About { get; set; }
        public DateTime FirstAccess { get; set; }
        public DateTime LastUpdate { get; set; }
        public long LegacyPortalUID { get; set; }
        public string XboxDisplayName { get; set; }
        public string FbDisplayName { get; set; }
        public bool ShowActivity { get; set; }
        public string Locale { get; set; }
        public bool LocaleInheritDefault { get; set; }
        public long LastBanReportId { get; set; }
        public bool ShowGroupMessaging { get; set; }
        public string ProfilePicturePath { get; set; }
        public string ProfilePictureWidePath { get; set; }
        public string ProfileThemeName { get; set; }
        public string UserTitleDisplay { get; set; }
        public string StatusText { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime ProfileBanExpire { get; set; }
        public string BlizzardDisplayName { get; set; }
        public string SteamDisplayName { get; set; }
        public string StadiaDisplayName { get; set; }
        public string TwitchDisplayName { get; set; }
    }
}
