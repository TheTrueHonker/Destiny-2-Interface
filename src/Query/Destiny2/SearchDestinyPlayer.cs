using Destiny_2_Interface.Enum;
using Destiny_2_Interface.Response;
using Destiny_2_Interface.Response.User;
using Destiny_2_Interface.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destiny_2_Interface.Query.Destiny2
{
    public static class SearchDestinyPlayer
    {
        private static readonly string BASE_URL = "https://www.bungie.net/Platform/Destiny2/SearchDestinyPlayer/";

        public static Response<UserInfoCard[]> GetUser(string apiKey, BungieMembershipType membershipType, string displayName)
        {
            string url = BASE_URL + membershipType + "/" + displayName;
            string content = HttpContextHelper.GetContent(apiKey, url);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response<UserInfoCard[]>>(content);
        }
    }
}
