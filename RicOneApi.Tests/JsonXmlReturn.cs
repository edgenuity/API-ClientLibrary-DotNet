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
        static string clientId = "CastleLearningOnline";
        //static string clientId = "dpaDemo";
        static string clientSecret = "836774581965d73924995cb4c02e9";
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
                //Console.WriteLine(xPress.GetXLeas().Header);
                //Console.WriteLine(xPress.GetXLeas().StatusCode);
                //if (xPress.GetXLeas().Data != null)
                //{
                //    //Console.WriteLine(xPress.GetXLeas().Json);
                //    //Console.WriteLine(xPress.GetXLeas().Xml);
                foreach (XLeaType l in xPress.GetXLeas().Data)
                {
                    Console.WriteLine("leaRefId: " + l.refId);
                    Console.WriteLine("leaName: " + l.leaName);
                }
                //}

                //foreach (XSchoolType s in xPress.GetXSchools().Data)
                //{
                //    Console.WriteLine(s.leaRefId);
                //}

            }


            Console.Read();
        }
    }
}
