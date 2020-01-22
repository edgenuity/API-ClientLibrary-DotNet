using RicOneApi.Models.Authentication;
using System.Collections.Generic;

namespace RicOneApi.Api
{
    public interface IAuthenticator
    {
        void Authenticate(string authUrl, string clientId, string clientSecret);
        Endpoint GetEndpoint(string providerId);
        List<Endpoint> GetEndpoints();
        List<Endpoint> GetEndpoints(string providerId);
        List<Endpoint> GetEndpoints(string providerId, bool returnAllEndpoints);
        string GetToken();
    }
}