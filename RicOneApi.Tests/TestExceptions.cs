using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClientLibraries
{
    class TestExceptions
    {

        static string authUrl = "https://auth.test.ricone.org/login";
        static string clientId = "dpaDemo";
        static string clientSecret = "deecd889bff5ed0101a86680752f5f9";
        //static string clientSecret = "deecd889bff5ed0101a86680752f5f";
        static string providerId = "localhost";
        static string refId = "9BA8379D-9A9D-4D59-9202-E976CADF5526";

        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);
            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);
                
                if (xPress.GetXLea(refId).Data != null)
                {
                    //foreach (XLeaType l in xPress.GetXLeas(refId).Data)
                    //{
                    XLeaType l = xPress.GetXLea(refId).Data;
                        Console.WriteLine("leaRefId: " + l.refId);
                        Console.WriteLine("leaName: " + l.leaName);
                    //}
                }
            }

            
            Console.Read();
        }
    }
}
