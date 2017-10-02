/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.4
 * Since       2016-09-12
 * Filename    NewAuth.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;

namespace RicOneApi.Tests
{
    class NewAuth
    {
        #region Test Constants
        static string authUrl = "https://auth.test.ricone.org/login";
        static string clientId = "dpaDemo";
        static string clientSecret = "deecd889bff5ed0101a86680752f5f9";
        static string providerId = "sandbox";
        #endregion

        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);

            foreach (Endpoint e in auth.GetEndpoints(providerId, false))
            {
                Console.WriteLine(e.name + " | " + e.href + " | " + e.provider_id + " | " + e.token + Console.Out.NewLine);
            }

            //while (true)
            //{
            //    foreach (Endpoint e in auth.GetEndpoints(providerId))
            //    {
            //        XPress xPress = new XPress(e.href);

            //        foreach (XLeaType l in xPress.GetXLeas().Data)
            //        {
            //            Console.WriteLine(e.provider_id + " | " + l.leaName + " | " + e.token);
            //            ////					for(XSchoolType s : xPress.getXSchoolsByXLea(l.getRefId()).getData())
            //            ////					{
            //            ////						System.out.println(s.getSchoolName() + " | " + e.getToken());
            //            ////					}
            //        }
            //    }
            //    //System.Threading.Thread.Sleep(5000);
            //    System.Threading.Thread.Sleep(300000);
            //}

            Console.Read();
        }
    }
}
