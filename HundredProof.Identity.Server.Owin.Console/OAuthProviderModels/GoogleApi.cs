namespace HundredProof.Identity.Server.Owin.Console.OAuthProviderModels
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GoogleApi
    {
        [JsonProperty("client_id")] public string ClientId { get; set; }

        [JsonProperty("project_id")] public string ProjectId { get; set; }

        [JsonProperty("auth_uri")] public Uri AuthUri { get; set; }

        [JsonProperty("token_uri")] public Uri TokenUri { get; set; }

        [JsonProperty("auth_provider_x509_cert_url")]
        public Uri AuthProviderX509CertUrl { get; set; }

        [JsonProperty("client_secret")] public string ClientSecret { get; set; }

        [JsonProperty("redirect_uris")] public Uri[] RedirectUris { get; set; }
    }
}