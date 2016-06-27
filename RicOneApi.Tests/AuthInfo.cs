using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace RicOneApi.Tests
{
    class AuthInfo
    {
        static void Main(string[] args)
        {
            string authUrl = ConfigurationManager.AppSettings["authUrl"];
            string authClientId = ConfigurationManager.AppSettings["authClientId"];
            string authClientSecret = ConfigurationManager.AppSettings["authClientSecret"];
            string authProviderId = ConfigurationManager.AppSettings["authProviderId"];
            string authToken = ConfigurationManager.AppSettings["authToken"];
            
            Console.WriteLine(authUrl);
            Console.WriteLine(authClientId);
            Console.WriteLine(authClientSecret);
            Console.WriteLine(authProviderId);
            Console.WriteLine(authToken);

            Console.Read();
        }
    }
}
