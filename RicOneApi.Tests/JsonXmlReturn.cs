using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Tests
{
    class JsonXmlReturn
    {
        static string authUrl = "https://auth.test.ricone.org/login";
        static string clientId = "dpaDemo";
        static string clientSecret = "deecd889bff5ed0101a86680752f5f9";
        static string providerId = "localhost";
        
        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);
            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);

                string json = xPress.GetXLeas().Json;
                string xml = xPress.GetXLeas(2018).Xml;
                Console.WriteLine(json);
                Console.WriteLine();
                Console.WriteLine(xml);

                //Console.WriteLine(xPress.GetXLea("03ACF04F-DC12-411A-9A42-E8323516D699").Json);
                //Console.WriteLine();
                //Console.WriteLine(xPress.GetXLea("03ACF04F-DC12-411A-9A42-E8323516D699").Xml);
            }
            Console.Read();
        }
    }
}
