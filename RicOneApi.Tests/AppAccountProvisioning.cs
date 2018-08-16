using RicOneApi.Api;
using System;
using System.Configuration;
using RicOneApi.Models.XPress;
using RicOneApi.Models.Authentication;

namespace RicOneApi.Tests
{
    class AppAccountProvisioning
    {
        static string authUrl = ConfigurationManager.AppSettings["authUrl"];
        static string clientId = ConfigurationManager.AppSettings["authClientId"];
        static string clientSecret = ConfigurationManager.AppSettings["authClientSecret"];
        static string providerId = ConfigurationManager.AppSettings["authProviderId"];

        const String SCHOOL_REFID = "AE6B3441-5E31-4573-BADB-081669D79C7F";
        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);

            //Get endpoints by provider
            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);

                //Staff
                //xPress.CreateXStaffUsers(SCHOOL_REFID);
                //xPress.DeleteXStaffUsers(SCHOOL_REFID);
                //xPress.DeleteXStaffUsernamesPasswords(SCHOOL_REFID);
                //XStaffs_GetXStaffsAccounts(xPress);

                //Student
                //xPress.CreateXStudentUsers(SCHOOL_REFID);
                //xPress.DeleteXStudentUsers(SCHOOL_REFID);
                //xPress.DeleteXStudentUsernamesPasswords(SCHOOL_REFID);
                //XStudents_GetXStudentsAccounts(xPress);

                Console.Read();
            }
        }

        public static void XStaffs_GetXStaffsAccounts(XPress xPress)
        {
            if (xPress.GetXStaffUsers(SCHOOL_REFID).Data != null)
            {
                foreach (XStaffType s in xPress.GetXStaffUsers(SCHOOL_REFID).Data)
                {
                    Console.WriteLine("loginId: " + s.appProvisioningInfo.loginId);
                    Console.WriteLine("tempPassword: " + s.appProvisioningInfo.tempPassword);
                    Console.WriteLine("tempExpiryDate: " + s.appProvisioningInfo.tempPasswordExpiryDate);
                }
            }
        }

        public static void XStudents_GetXStudentsAccounts(XPress xPress)
        {
            if (xPress.GetXStudentUsers(SCHOOL_REFID).Data != null)
            {
                foreach (XStudentType s in xPress.GetXStudentUsers(SCHOOL_REFID).Data)
                {
                    Console.WriteLine("loginId: " + s.appProvisioningInfo.loginId);
                    Console.WriteLine("tempPassword: " + s.appProvisioningInfo.tempPassword);
                    Console.WriteLine("tempExpiryDate: " + s.appProvisioningInfo.tempPasswordExpiryDate);
                }
            }
        }
    }
}
