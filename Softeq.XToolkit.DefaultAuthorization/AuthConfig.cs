﻿
namespace Softeq.XToolkit.DefaultAuthorization
{
    public class AuthConfig
    {
        public AuthConfig(string baseUrl, string clientId, string clientSecret)
        {
            BaseUrl = baseUrl;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public string BaseUrl { get; }

        public string ClientId { get; }

        public string ClientSecret { get; }
    }
}
