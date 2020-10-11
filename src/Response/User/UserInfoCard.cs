using Destiny_2_Interface.Enum;

namespace Destiny_2_Interface.Response.User
{
    public class UserInfoCard
    {
        public string SupplementalDisplayName { get; set; }
        public string IconPath { get; set; }
        public bool IsPublic { get; set; }
        public BungieMembershipType MembershipType { get; set; }
        public long MembershipId { get; set; }
        public string DisplayName { get; set; }
    }
}
