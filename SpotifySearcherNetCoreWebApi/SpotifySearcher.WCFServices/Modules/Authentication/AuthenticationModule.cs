using Newtonsoft.Json;
using SpotifySearcher.WCFServices.Modules.Authentication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SpotifySearcher.WCFServices.Modules.Authentication
{
    public class AuthenticationModule : IAuthenticationModule
    {
        private readonly HttpClient _client;

        public AuthenticationModule()
        {
            string clientId = ConfigurationManager.AppSettings["ClientID"]; 
            string clientSecret = ConfigurationManager.AppSettings["ClientSecret"];
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };
            _client = new HttpClient(handler);
            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseURLAPIAuth"]);
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            var byteArray = Encoding.ASCII.GetBytes(clientId + ":" + clientSecret);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public async Task<AuthenticationResponse> Authenticate()
        {
            var authenticationResponse = new AuthenticationResponse();
            string url = "/api/token";
            
            var nvc = new List<KeyValuePair<string, string>>();
            nvc.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(nvc) };
            var response = await _client.SendAsync(req);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var tokenOk = JsonConvert.DeserializeObject<TokenResponseOk>(json);
                authenticationResponse.ResponseOk = tokenOk;
                authenticationResponse.IsAuthenticated = true;
            }
            else
            {
                var json = await response.Content.ReadAsStringAsync();
                var tokenError = JsonConvert.DeserializeObject<TokenResponseError>(json);
                authenticationResponse.ResponseError = tokenError;
                authenticationResponse.IsAuthenticated = false;
            }
            
            return authenticationResponse;
        }
    }
}