using System;
using System.Collections.Generic;
using RestSharp;
using RicOneApi.Models.Authentication;
using RicOneApi.Exceptions;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7.0
 * Since       2019-03-29
 * Filename    Authenticator.cs
 */
namespace RicOneApi.Api
{
    /// <summary>
    /// Contains methods to authenticate and pull data from auth server.
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
        private static string _message;

        private Authenticator() { }

        /// <summary>
        /// Singleton instantiation.
        /// </summary>
        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Authenticator();
                }
                return instance;
            }
        }

        /// <summary>
        /// Establish connection to authenticate to OAuth server.
        /// </summary>
        /// <param name="authUrl">The authentication server url.</param>
        /// <param name="clientId">The clientId for the application.</param>
        /// <param name="clientSecret">The clientSecret for the application.</param>
        public void Authenticate(string authUrl, string clientId, string clientSecret)
        {
            _authUrl = authUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _client = new RestClient(_authUrl);
            Login(clientId, clientSecret);
        }

        /// <summary>
        /// POST to authentication server with provided credentials.
        /// </summary>
        /// <param name="clientId">The clientId for the application.</param>
        /// <param name="clientSecret">The clientSecret for the application.</param>
        private void Login(string clientId, string clientSecret)
        {
            try
            {
                _request = new RestRequest(Method.POST);
                _request.AddParameter("username", clientId, ParameterType.GetOrPost);
                _request.AddParameter("password", clientSecret, ParameterType.GetOrPost);
                _response = _client.Execute<UserInfo>(_request);
               
                if (_response.ErrorException != null)
                {
                    throw new AuthenticationException();
                }
            }
            catch (Exception e)
            {
                throw new AuthenticationException("401 UNAUTHORIZED", e);
            }

        }

        /// <summary>
        /// Re-authenticates with authentication server if token is expired.
        /// </summary>
        internal void RefreshToken()
        {

            Login(_clientId, _clientSecret);
        }

        /// <summary>
        /// Retrieve an application's token.
        /// </summary>
        /// <returns>Token value of type String.</returns>
        public String GetToken()
        {
            return _response.Data.token;
        }

        /// <summary>
        /// Details of a specific endpoint by providerId.
        /// </summary>
        /// <param name="providerId">The providerId to be returned.</param>
        /// <returns>A list of type Endpoint by specified providerId.</returns>
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
        /// A list of all endpoints an application is associated with and it's details.
        /// </summary>
        /// <returns>A list of type Endpoint.</returns>
        public List<Endpoint> GetEndpoints()
        {
            return _response.Data.endpoint;
        }

        /// <summary>
        /// Details of a single endpoint if returnAllEndpoints set to false. If returnAllEndpoints is true,
        /// details of all endpoints associated to application are returned.
        /// </summary>
        /// <param name="providerId">The providerId to be returned.</param>
        /// <param name="returnAllEndpoints">All endpoints the application is associated with.</param>
        /// <returns>A list of type Endpoint if Boolean set to true otherwise a single endpoint.</returns>
        public List<Endpoint> GetEndpoints(string providerId, bool returnAllEndpoints)
        {
            List<Endpoint> endpoints = new List<Endpoint>();

            foreach (Endpoint e in _response.Data.endpoint)
            {
                if (returnAllEndpoints)
                {
                    endpoints.Add(e);
                }
                else if (e.provider_id.Equals(providerId))
                {
                    endpoints.Add(e);
                }
            }
            return endpoints;
        }

        /// <summary>
        /// A single endpoint an application is associated with and it's details.
        /// </summary>
        /// <param name="providerId">The providerId to be returned.</param>
        /// <returns>A single Endpoint type.</returns>
        public Endpoint GetEndpoint(string providerId)
        {
            Endpoint endpoint = null;

            foreach (Endpoint e in _response.Data.endpoint)
            {
                if(e.provider_id.Equals(providerId))
                {
                    endpoint = e;
                }
            }
            return endpoint;
        }

        /// <summary>
        /// For testing token validation
        /// </summary>
        /// <returns></returns>
        private string GetMessage()
        {
            return _message;
        }

        /// <summary>
        /// For testing token validation, set in RestReturn class
        /// </summary>
        /// <param name="message"></param>
        internal void SetMessage(string message)
        {
            _message = message;
        }
    }
}