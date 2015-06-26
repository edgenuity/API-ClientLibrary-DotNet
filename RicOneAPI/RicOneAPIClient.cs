using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RicOneAPI.Models.Authentication;
using RicOneAPI.Models.SIFxPress;
using RicOneAPI;

namespace RicOneAPI.Api
{
    /// <summary>
    /// Contains the calls to consume the RicOne API.
    /// </summary>
    public class RicOneAPIClient
    {
        private string token;
        private RestClient restClient;
        private string baseApiUrl;
        public SIFxPress sifXpress;

        /// <summary>
        /// Use endpoint values to authenticate to data API
        /// </summary>
        /// <param name="endpoint"></param>
        public RicOneAPIClient(Endpoint endpoint)
        {
            this.token = endpoint.token;
            this.baseApiUrl = endpoint.href;
            this.restClient = new RestClient(baseApiUrl);
            restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");
            sifXpress = new SIFxPress(token, baseApiUrl, restClient);

        }
        /// <summary>
        /// Use endpoint values to authenticate to data API
        /// </summary>
        /// <param name="token"></param>
        /// <param name="baseApiUrl"></param>
        public RicOneAPIClient(string token, string baseApiUrl)
        {
            this.token = token;
            this.baseApiUrl = baseApiUrl;
            this.restClient = new RestClient(baseApiUrl);
            restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");
            sifXpress = new SIFxPress(token, baseApiUrl, restClient);
           
        }
    }
}
