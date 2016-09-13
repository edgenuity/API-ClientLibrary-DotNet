using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
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
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);

            //string token = auth.GetToken();
            DecodedToken dt = new DecodedToken(auth.GetToken());

            Console.WriteLine(dt.GetDecodedToken().application_id);
            Console.WriteLine(dt.GetDecodedToken().iss);
            Console.WriteLine(dt.GetDecodedToken().iat);
            Console.WriteLine(dt.GetDecodedToken().exp);

            Console.Read(); 
        }

    }
}
