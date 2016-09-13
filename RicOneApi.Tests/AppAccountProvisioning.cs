using RicOneApi.Api;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using RicOneApi.Models.XPress;
namespace RicOneApi.Tests
{
    class AppAccountProvisioning
    {
        static string authUrl = ConfigurationManager.AppSettings["authUrl"];
        static string clientId = ConfigurationManager.AppSettings["authClientId"];
        static string clientSecret = ConfigurationManager.AppSettings["authClientSecret"];
        static string providerId = ConfigurationManager.AppSettings["authProviderId"];

        //static string refId = "0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C";
        static string refId = "106E9449-3FF4-499E-B94F-BCE557C013CE";
        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);

            //Get endpoints by provider
            foreach (RicOneApi.Models.Authentication.Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);

                //Staff
                //xPress.CreateXStaffUsers(refId);
                //xPress.DeleteXStaffUsers(refId);
                //XStaffs_GetXStaffsAccounts(xPress);

                //Student
                //xPress.CreateXStudentUsers(refId);
                //xPress.DeleteXStudentUsers(refId);
                //XStudents_GetXStudentsAccounts(xPress);

                //Contact
                //xPress.CreateXContactUsers(refId);
                //xPress.DeleteXContactUsers(refId);
                //xPress.GetXContactUsers("0F4DE8DE-5AA3-48A7-A330-62E0B8910F1C");

                Console.Read();
            }
        }

        public static void XStaffs_GetXStaffsAccounts(XPress xPress)
	    {
		    if(xPress.GetXStaffUsers(refId).Data !=null)
		    {
			    foreach(XStaffType s in xPress.GetXStaffUsers(refId).Data)
			    {
                    Console.WriteLine("loginId: " + s.appProvisioningInfo.loginId);
                    Console.WriteLine("tempPassword: " + s.appProvisioningInfo.tempPassword);
                    Console.WriteLine("tempExpiryDate: " + s.appProvisioningInfo.tempPasswordExpiryDate);
			    }
		    }
	    }

        public static void XStudents_GetXStudentsAccounts(XPress xPress)
	    {
		    if(xPress.GetXStudentUsers(refId).Data !=null)
		    {
			    foreach(XStudentType s in xPress.GetXStudentUsers(refId).Data)
			    {
				    Console.WriteLine("loginId: " + s.appProvisioningInfo.loginId);
			    	Console.WriteLine("tempPassword: " + s.appProvisioningInfo.tempPassword);
			    	Console.WriteLine("tempExpiryDate: " + s.appProvisioningInfo.tempPasswordExpiryDate);
			    }
		    }
	    }
    }
}
