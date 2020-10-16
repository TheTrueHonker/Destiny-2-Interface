using Destiny_2_Interface.Response.Destiny.Entities.Profiles;

namespace Destiny_2_Interface.Response.Components
{
    public class SingleComponentResponseOfDestinyProfileComponent
    {
        public DestinyProfileComponent Data { get; set; }
        public int Privacy { get; set; }
        public bool Disabled { get; set; }
    }
}
