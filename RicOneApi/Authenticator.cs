/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1.1
 * Since       2015-09-11
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
    /// Contains methods to authenticate and pull data from OAuth server
    /// </summary>
    public class Authenticator
    {
        const string oauthBaseUrl = "http://auth.ricone.org/login";

        private string username;
        private string password;

        private readonly RestClient client;

        /// <summary>
        /// Establish connection to authenticate to OAuth server
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="restClient"></param>
        public Authenticator(string username, string password, RestClient restClient = null)
        {
            this.username = username;
            this.password = password;
            client = restClient ?? new RestClient(oauthBaseUrl);
        }
        /// <summary>
        /// Request user id, user_name, token, and list of endpoints
        /// </summary>
        /// <returns></returns>
        public UserInfo GetUserInfo()
        {
            client.Authenticator = new SimpleAuthenticator("username", this.username, "password", this.password);

            var request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            request.AddParameter("username", this.username, ParameterType.RequestBody);
            request.AddParameter("password", this.password, ParameterType.RequestBody);

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
            client.Authenticator = new SimpleAuthenticator("username", this.username, "password", this.password);

            var request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            request.AddParameter("username", this.username, ParameterType.RequestBody);
            request.AddParameter("password", this.password, ParameterType.RequestBody);

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
            client.Authenticator = new SimpleAuthenticator("username", this.username, "password", this.password);

            var request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            request.AddParameter("username", this.username, ParameterType.RequestBody);
            request.AddParameter("password", this.password, ParameterType.RequestBody);

            var response = client.Execute<UserInfo>(request);

            return response.Data.endpoint;

        }
    }
}
