using RicOneApi.Api;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace RicOneApi.Tests
{
    class AppAccountProvisioning
    {
        static string authUrl = ConfigurationManager.AppSettings["authUrl"];
        static string clientId = ConfigurationManager.AppSettings["authClientId"];
        static string clientSecret = ConfigurationManager.AppSettings["authClientSecret"];
        static string providerId = ConfigurationManager.AppSettings["authProviderId"];

        static void Main(string[] args)
        {
            Authenticator auth = new Authenticator(authUrl, clientId, clientSecret);
            //Get endpoints by provider
            foreach (RicOneApi.Models.Authentication.Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(auth.GetToken(), e.href);

                //Staff
                xPress.CreateXStaffUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");
                xPress.DeleteXStaffUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");
                xPress.GetXStaffUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");

                //Student
                xPress.CreateXStudentUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");
                xPress.DeleteXStudentUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");
                xPress.GetXStudentUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");

                //Contact
                //xPress.CreateXContactUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");
                //xPress.DeleteXContactUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");
                //xPress.GetXContactUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");

                Console.Read();
            }
        }
    }
}
