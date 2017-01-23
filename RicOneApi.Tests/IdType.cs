using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Tests
{
    class IdType
    {
        static string authUrl = "https://auth.test.ricone.org/login";
        static string clientId = "dpaDemo";
        static string clientSecret = "deecd889bff5ed0101a86680752f5f9";
        static string providerId = "localhost";
        static string refId = "9BA8379D-9A9D-4D59-9202-E976CADF5526";

        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);
            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);

                //XLeaType l = xPress.GetXLea("beds", "738121").getData();
                XLeaType l = xPress.GetXLea("local", "BT101").Data;
                Console.WriteLine(l.refId);
			    Console.WriteLine(l.localId);
			    Console.WriteLine(l.stateProvinceId);
                Console.WriteLine(l.leaName);
            }


            Console.Read();
        }
    }
}
