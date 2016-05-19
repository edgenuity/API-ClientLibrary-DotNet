using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RicOneApi.Api;

namespace RicOneApi.Tests
{
    class TokenInfo
    {
        #region Test Constants
        const string authUrl = "http://auth.test.ricone.org/login";
        const string clientId = "dpaDemo";
        const string clientSecret = "65ee6dc913d9023f1ee94ab33c3cae38c57";
        #endregion
        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(authUrl, clientId, clientSecret);

            string token = auth.GetToken();
            
            Console.WriteLine(auth.GetDecodedToken(token).application_id);
            Console.WriteLine(auth.GetDecodedToken(token).iss);
            Console.WriteLine(auth.GetDecodedToken(token).iat);
            Console.WriteLine(auth.GetDecodedToken(token).exp);
           
            Console.Read(); 
        }

    }
}
