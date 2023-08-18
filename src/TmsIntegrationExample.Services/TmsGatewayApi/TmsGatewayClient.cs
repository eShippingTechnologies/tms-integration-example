// <copyright file="TmsGatewayClient.cs" company="Engaged Technologies">
//      Copyright (c) Engaged Technologies. All rights reserved.
//  </copyright>
// <summary>
//     Implementation of ITmsGatewayClient
// </summary>

namespace TmsIntegrationExample.Services.TmsGatewayApi
{
    using IdentityModel;
    using IdentityModel.Client;
    using Microsoft.Extensions.Options;
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Net.Http.Json;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using TmsIntegrationExample.Services.Extensions;
    using TmsIntegrationExample.Services.TmsGatewayApi.Configuration;
    using TmsIntegrationExample.Services.TmsGatewayApi.Model;

    public class TmsGatewayClient : ITmsGatewayClient
    {
        private readonly JsonSerializerOptions jsonSerializerOptions;
        private readonly HttpClient httpClient;
        private readonly TmsGatewayConfiguration tmsGatewayConfiguration;
        private TokenResponse accessToken;

        public TmsGatewayClient(
            HttpClient httpClient,
            IOptions<TmsGatewayConfiguration> tmsGatewayConfiguration,
            JsonSerializerOptions jsonSerializerOptions)
        {
            this.tmsGatewayConfiguration = tmsGatewayConfiguration.Value;
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = this.tmsGatewayConfiguration.BaseAddress;
            this.jsonSerializerOptions = jsonSerializerOptions;
        }

        public async Task<Shipment> PostShipmentAsync(ShipmentPost shipment)
        {
            accessToken = await GetAccessTokenAsync();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken.AccessToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var jsonContent = JsonConvert.SerializeObject(shipment);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"{tmsGatewayConfiguration.ShipmentsSubPath}", contentString);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Shipment>(jsonSerializerOptions);
        }

        public async Task<TokenResponse> GetAccessTokenAsync()
        {
            // Create an http client for all of the requests
            var loginHttpClient = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false }) { BaseAddress = this.tmsGatewayConfiguration.LoginBaseAddress };

            // login
            await loginHttpClient.PostAsync(
                this.tmsGatewayConfiguration.LoginSubPath,
                new StringContent(System.Text.Json.JsonSerializer.Serialize(new { this.tmsGatewayConfiguration.Email, this.tmsGatewayConfiguration.Password }), Encoding.UTF8, "application/json"));

            // instantiate state, code verifier, and verifier challenge
            var state = Helpers.CreateRandomString(128);
            var verifier = Helpers.CreateRandomString(128);
            var challenge = verifier.ToCodeChallenge();

            // Create a relative url for requesting the authorization code
            var url = new RequestUrl(this.tmsGatewayConfiguration.AuthorizeSubPath).CreateAuthorizeUrl(
                responseType: "code",
                clientId: this.tmsGatewayConfiguration.ClientId,
                redirectUri: this.tmsGatewayConfiguration.RedirectUri,
                scope: "openid profile engTech",
                state: state,
                codeChallenge: challenge,
                codeChallengeMethod: OidcConstants.CodeChallengeMethods.Sha256);

            // Send the request for the authorization code and extract it from the location header
            var authorizeResponse = await loginHttpClient.GetAsync(url);
            var code = System.Web.HttpUtility.ParseQueryString(authorizeResponse.Headers.Location.Query)["code"];

            // Request the access token
            var tokenResponse = await new TokenClient(loginHttpClient, new TokenClientOptions { Address = this.tmsGatewayConfiguration.TokenSubPath, ClientId = this.tmsGatewayConfiguration.ClientId })
                .RequestAuthorizationCodeTokenAsync(
                    code,
                    this.tmsGatewayConfiguration.RedirectUri,
                    verifier);

            return tokenResponse;

        }
    }
}
