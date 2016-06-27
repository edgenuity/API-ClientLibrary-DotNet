/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.2.1
 * Since       2016-05-18
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
        private static readonly Authenticator instance = new Authenticator();
        private string authUrl;
        private string clientId;
        private string clientSecret;

        private readonly RestClient _client;
        private RestRequest _request;

        private Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                return instance;
            }
        }

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
            _client = restClient ?? new RestClient(authUrl);

        }
        /// <summary>
        /// Request user id, user_name, token, and list of endpoints
        /// </summary>
        /// <returns></returns>
        public UserInfo GetUserInfo()
        {
            _client.Authenticator = new SimpleAuthenticator("username", this.clientId, "password", this.clientSecret);

            _request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            _request.AddParameter("username", this.clientId, ParameterType.RequestBody);
            _request.AddParameter("password", this.clientSecret, ParameterType.RequestBody);

            var response = _client.Execute<UserInfo>(_request);

            return response.Data;
        }

        /// <summary>
        /// Token value
        /// </summary>
        /// <returns></returns>
        public String GetToken()
        {
            _client.Authenticator = new SimpleAuthenticator("username", this.clientId, "password", this.clientSecret);

            _request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            _request.AddParameter("username", this.clientId, ParameterType.RequestBody);
            _request.AddParameter("password", this.clientSecret, ParameterType.RequestBody);

            var response = _client.Execute<UserInfo>(_request);

            return response.Data.token;
        }

        /// <summary>
        /// Request all endpoints
        /// </summary>
        /// <param name="providerId"></param>
        /// <returns></returns>
        public List<Endpoint> GetEndpoints(string providerId)
        {
            _client.Authenticator = new SimpleAuthenticator("username", this.clientId, "password", this.clientSecret);

            _request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            _request.AddParameter("username", this.clientId, ParameterType.RequestBody);
            _request.AddParameter("password", this.clientSecret, ParameterType.RequestBody);

            var response = _client.Execute<UserInfo>(_request);

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
            _client.Authenticator = new SimpleAuthenticator("username", this.clientId, "password", this.clientSecret);

            _request = new RestRequest(Method.POST);

            // Adds Request Body parameters for username and password
            _request.AddParameter("username", this.clientId, ParameterType.RequestBody);
            _request.AddParameter("password", this.clientSecret, ParameterType.RequestBody);

            var response = _client.Execute<UserInfo>(_request);

            return response.Data.endpoint;

        }

        /// <summary>
        /// Payload data inside an encrypted JWT token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public DecodedToken GetDecodedToken(String token)
        {
            try
            {
                //Console.WriteLine(token);
                String[] base64EncodedSegments = token.Split('.');
                DecodedToken dt = JsonConvert.DeserializeObject<DecodedToken>(base64UrlDecode(base64EncodedSegments[1]));

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public String base64UrlDecode(String input)
        {
            byte[] newBytes = JWT.JsonWebToken.Base64UrlDecode(input);
            return System.Text.Encoding.UTF8.GetString(newBytes);
        }
    }
}