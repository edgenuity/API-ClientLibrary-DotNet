/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.4
 * Since       2016-09-12
 * Filename    Authenticator.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using RicOneApi.Models.Authentication;
using Newtonsoft.Json;

namespace RicOneApi.Api
{
    /// <summary>
    /// Contains methods to authenticate and pull data from auth server
    /// </summary>
    public class Authenticator
    {
        private static Authenticator instance = new Authenticator();
        private static RestClient _client;
        private static RestRequest _request;
        private static IRestResponse<UserInfo> _response;
        private static string _authUrl;
        private static string _clientId;
        private static string _clientSecret;

        private Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Authenticator();
                }
                return instance;
            }
        }
       
         /// <summary>
        /// Establish connection to authenticate to authentication server
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="restClient"></param>
        public void Authenticate(string authUrl, string clientId, string clientSecret)
        {
            _authUrl = authUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _client = new RestClient(authUrl);
            Login(authUrl, clientId, clientSecret);
        }

        /// <summary>
        /// Post to authentication server with provided credentials
        /// </summary>
        /// <param name="authUrl"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        private void Login(string authUrl, string clientId, string clientSecret)
        {
            _client.Authenticator = new SimpleAuthenticator("username", clientId, "password", clientSecret);
            //_request = SetRequest(clientId, clientSecret);   

            _request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            _request.AddParameter("username", clientId, ParameterType.RequestBody);
            _request.AddParameter("password", clientSecret, ParameterType.RequestBody);

            _response = _client.Execute<UserInfo>(_request);
        }

        /// <summary>
        /// Re-authenticates with authentication server if token is expired
        /// </summary>
        internal void RefreshToken()
        {

            Login(_authUrl, _clientId, _clientSecret);
        }

        // <summary>
        /// Token value
        /// </summary>
        /// <returns></returns>
        public String GetToken()
        {
            return _response.Data.token;
        }

        /// <summary>
        /// Endpoint by specified providerId
        /// </summary>
        /// <param name="providerId"></param>
        /// <returns></returns>
        public List<Endpoint> GetEndpoints(string providerId)
        {
            List<Endpoint> endpoints = new List<Endpoint>();

            foreach (Endpoint e in _response.Data.endpoint)
            {
                if (e.provider_id.Equals(providerId))
                {
                    endpoints.Add(e);
                }
            }
            return endpoints;
        }
        /// <summary>
        /// All endpoints
        /// </summary>
        /// <returns></returns>
        public List<Endpoint> GetEndpoints()
        {
            return _response.Data.endpoint;
        }
    }
}