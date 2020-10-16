using Destiny_2_Interface.Enum;
using Destiny_2_Interface.Response;
using Destiny_2_Interface.Response.Destiny.Entities.Profiles;
using Destiny_2_Interface.Utility;
using System;
using Destiny_2_Interface.Response.User;

namespace Destiny_2_Interface.Query.Destiny2
{
    public static class GetProfile
    {
        private static readonly string BASE_URL = "https://www.bungie.net/Platform/Destiny2/";
        private static readonly string EXT1_URL = "/Profile/";

        public static Response<DestinyProfileResponse> GetUser(string apiKey, BungieMembershipType membershipType, long destinyMembershipId, DestinyComponentType[] components)
        {
            string url = BASE_URL + membershipType + EXT1_URL + destinyMembershipId + "?components=";
            for(int i = 0; i < components.Length; i++)
            {
                url += components[i];
                if(i+1 >= components.Length)
                {
                    url += ",";
                }
            }
            string content = HttpContextHelper.GetContent(apiKey, url);
            Console.WriteLine(content);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response<DestinyProfileResponse>>(content);
        }
    }
}
