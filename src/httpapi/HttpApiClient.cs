﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    public class HttpApiClient
    {

        public string BaseUrl { get; }

        private RestClient restClient;

        public HttpApiClient(string baseUrl)
        {
            BaseUrl = baseUrl;
            restClient = new RestClient(BaseUrl);
        }

    }
}