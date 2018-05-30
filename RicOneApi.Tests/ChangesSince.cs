using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using System;

namespace RicOneApi.Tests
{
    class ChangesSince
    {
        #region Test Constants
        static string authUrl = "https://auth.test.ricone.org/login";
        static string clientId = "dpaDemo";
        static string clientSecret = "deecd889bff5ed0101a86680752f5f9";
        static string providerId = "localhost";
        #endregion

        static void Main(string[] args)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(authUrl, clientId, clientSecret);

            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                XPress xPress = new XPress(e.href);
                //DateTime dt = DateTime.Now;
                //Console.WriteLine(dt.ToString("s"));
                //Console.WriteLine(Util.TimestampToISO8601(dt));

                //foreach (XCalendarType c in xPress.GetXCalendars("2016-12-10T15:31:45").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
                //foreach (XContactType c in xPress.GetXContacts("2016-12-10T15:38:45").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
                //foreach (XCourseType c in xPress.GetXCourses("2016-02-08T15:39:06").Data)
                //{
                //    Console.WriteLine(c.refId);
                //    Console.WriteLine(c.courseTitle);
                //}
                //foreach (XLeaType c in xPress.GetXLeas("2016-12-12T15:39:06").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
                //foreach (XRosterType c in xPress.GetXRosters("2016-12-12T15:30:06").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
                //foreach (XSchoolType c in xPress.GetXSchools("2016-02-08T15:30:17").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
                //foreach (XSchoolType c in xPress.GetXSchools("2016-02-08T15:30:17").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
                //foreach (XStaffType c in xPress.GetXStaffs("2016-02-08T15:29:57").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
                //foreach (XStudentType c in xPress.GetXStudents("2019-02-08T15:30:57").Data)
                //{
                //    Console.WriteLine(c.refId);
                //}
            }

            Console.Read();
        }
    }
}
