/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.3.1
 * Since       2016-07-20
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
        static string clientSecret = "65ee6dc913d9023f1ee94ab33c3cae38c57";
        static string providerId = "workshop";
        #endregion

        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(authUrl, clientId, clientSecret);
            while (true)
            {
                foreach (Endpoint e in auth.GetEndpoints())
                {
                    XPress xPress = new XPress(e.href);

                    foreach (XLeaType l in xPress.GetXLeas().Data)
                    {
                        Console.WriteLine(e.provider_id + " | " + l.leaName + " | " + e.token);
                        ////					for(XSchoolType s : xPress.getXSchoolsByXLea(l.getRefId()).getData())
                        ////					{
                        ////						System.out.println(s.getSchoolName() + " | " + e.getToken());
                        ////					}
                    }
                }
                //System.Threading.Thread.Sleep(5000);
                System.Threading.Thread.Sleep(300000);
            }

            Console.Read();
        }
    }
}
