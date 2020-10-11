﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destiny_2_Interface.Response
{
    public class Response<T>
    {
            [JsonProperty(PropertyName = "Response")]
            public T Data { get; set; }
            public int ErrorCode { get; set; }
            public int ThrottleSeconds { get; set; }
            public string ErrorStatus { get; set; }
            public string Message { get; set; }
            public IDictionary<string, string> MessageData { get; set; }
            public string DetailedErrorTrace { get; set; }
    }
}
