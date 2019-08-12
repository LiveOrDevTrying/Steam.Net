﻿using Newtonsoft.Json;

namespace Steam.Net.Lib.Responses
{
    public class SteamTransactionResponse
    {
        public Response response { get; set; }

        public class Response
        {
            public string result { get; set; }
            [JsonProperty(PropertyName = "params")]
            public Params _params { get; set; }
            public Errors error { get; set; }
        }

        public class Params
        {
            public string orderid { get; set; }
            public string transid { get; set; }
            public string steamid { get; set; }
            public string status { get; set; }
            public string currency { get; set; }
            public string time { get; set; }
            public string country { get; set; }
            public string usstate { get; set; }
            public Item[] items;

            public class Item
            {
                public string itemid { get; set; }
                public int qty { get; set; }
                public string amount { get; set; }
                public string vat { get; set; }
                public string itemstatus { get; set; }
            }
        }

        public class Errors
        {
            public string errorcode { get; set; }
            public string errordesc { get; set; }
        }
    }
}
