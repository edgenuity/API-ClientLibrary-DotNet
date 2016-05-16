/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.2
 * Since       2016-05-16
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

namespace RicOneApi.Api
{
    /// <summary>
    /// Contains methods to authenticate and pull data from auth server
    /// </summary>
    public class Authenticator
    {
        private string authUrl;
        private string clientId;
        private string clientSecret;

        private readonly RestClient client;

        /// <summary>
        /// Establish connection to authenticate to auth server
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="restClient"></param>
        public Authenticator(string authUrl, string clientId, string clientSecret, RestClient restClient = null)
        {
            this.authUrl = authUrl;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            client = restClient ?? new RestClient(authUrl);
        }
        /// <summary>
        /// Request user id, user_name, token, and list of endpoints
        /// </summary>
        /// <returns></returns>
        public UserInfo GetUserInfo()
        {
            client.Authenticator = new SimpleAuthenticator("username", this.clientId, "password", this.clientSecret);

            var request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            request.AddParameter("username", this.clientId, ParameterType.RequestBody);
            request.AddParameter("password", this.clientSecret, ParameterType.RequestBody);

            var response = client.Execute<UserInfo>(request);
            
            return response.Data;
        }

        /// <summary>
        /// Request all endpoints
        /// </summary>
        /// <param name="providerId"></param>
        /// <returns></returns>
        public List<Endpoint> GetEndpoints(string providerId)
        {
            client.Authenticator = new SimpleAuthenticator("username", this.clientId, "password", this.clientSecret);

            var request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            request.AddParameter("username", this.clientId, ParameterType.RequestBody);
            request.AddParameter("password", this.clientSecret, ParameterType.RequestBody);

            var response = client.Execute<UserInfo>(request);

            List<Endpoint> endpoints = new List<Endpoint>();

            foreach (Endpoint e in response.Data.endpoint)
            {
                if (e.provider_id.Equals(providerId))
                {
                    endpoints.Add(e);
                }
            }

            return endpoints;
        
        }
        /// <summary>
        /// Request all endpoints
        /// </summary>
        /// <returns></returns>
        public List<Endpoint> GetEndpoints()
        {
            client.Authenticator = new SimpleAuthenticator("username", this.clientId, "password", this.clientSecret);

            var request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            request.AddParameter("username", this.clientId, ParameterType.RequestBody);
            request.AddParameter("password", this.clientSecret, ParameterType.RequestBody);

            var response = client.Execute<UserInfo>(request);

            return response.Data.endpoint;

        }
    }
}
