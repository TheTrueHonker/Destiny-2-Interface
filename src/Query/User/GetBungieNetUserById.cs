using Destiny_2_Interface.Enum;
using Destiny_2_Interface.Response;
using Destiny_2_Interface.Response.User;
using Destiny_2_Interface.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destiny_2_Interface.Query.User
{
    public static class GetBungieNetUserById
    {
        private static readonly string BASE_URL = "https://www.bungie.net/Platform/User/GetBungieNetUserById/";

        public static Response<GeneralUser> GetUser(string apiKey, long id)
        {
            string url = BASE_URL + id + "/";
            string content = HttpContextHelper.GetContent(apiKey, url);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response<GeneralUser>>(content);
        }
    }
}
