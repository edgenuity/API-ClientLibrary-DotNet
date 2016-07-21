using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RicOneApi.Api;
using System.Configuration;

namespace RicOneApi.Tests
{
    class TokenInfo
    {
        #region Test Constants
        static string authUrl = ConfigurationManager.AppSettings["authUrl"];
        static string clientId = ConfigurationManager.AppSettings["authClientId"];
        static string clientSecret = ConfigurationManager.AppSettings["authClientSecret"];
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
