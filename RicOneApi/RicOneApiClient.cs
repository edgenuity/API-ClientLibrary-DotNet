///*
// * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
// * Version     1.2
// * Since       2016-05-05
// * Filename    RicOneApiClient.cs
// */
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;
//using RestSharp;
//using RestSharp.Authenticators;
//using RestSharp.Deserializers;
//using RicOneApi.Models.Authentication;
//using RicOneApi.Models.XPress;
//using RicOneApi;

//namespace RicOneApi.Api
//{
//    /// <summary>
//    /// Contains the calls to consume the RicOne API.
//    /// </summary>
//    public class RicOneApiClient
//    {
//        private string token;
//        private RestClient restClient;
//        private string baseApiUrl;
//        public XPress xPress;

//        /// <summary>
//        /// Use endpoint values to authenticate to data API
//        /// </summary>
//        /// <param name="endpoint"></param>
//        public RicOneApiClient(Endpoint endpoint)
//        {
//            this.token = endpoint.token;
//            this.baseApiUrl = endpoint.href;
//            this.restClient = new RestClient(baseApiUrl);
//            restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");
//            xPress = new XPress(token, baseApiUrl, restClient);

//        }
//        /// <summary>
//        /// Use endpoint values to authenticate to data API
//        /// </summary>
//        /// <param name="token"></param>
//        /// <param name="baseApiUrl"></param>
//        public RicOneApiClient(string token, string baseApiUrl)
//        {
//            this.token = token;
//            this.baseApiUrl = baseApiUrl;
//            this.restClient = new RestClient(baseApiUrl);
//            restClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");
//            xPress = new XPress(token, baseApiUrl, restClient);
           
//        }
//    }
//}
