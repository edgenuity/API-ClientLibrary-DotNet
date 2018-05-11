//using RicOneApi.Api;
//using RicOneApi.Models.Authentication;
//using RicOneApi.Models.XPress;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RicOneApi.Tests
//{
//    class Test
//    {
//        #region Test Constants
//        static string authUrl = "https://auth.test.ricone.org/login";
//        static string clientId = "dpaDemo";
//        static string clientSecret = "deecd889bff5ed0101a86680752f5f9";
//        static string providerId = "localhost";
//        #endregion

//        static void Main(string[] args)
//        {
//            Authenticator auth = Authenticator.Instance;
//            auth.Authenticate(authUrl, clientId, clientSecret);

//            foreach (Endpoint e in auth.GetEndpoints(providerId))
//            {
//                XPress xPress = new XPress(e.href);

//                if (xPress.GetXRostersByXLea("9BA8379D-9A9D-4D59-9202-E976CADF5526").Data != null)
//                {
//                    foreach (XRosterType r in xPress.GetXRostersByXLea("9BA8379D-9A9D-4D59-9202-E976CADF5526").Data)
//                    {
//                        Console.WriteLine("refId: " + r.refId);
//                        Console.WriteLine("courseRefId: " + r.courseRefId);
//                        Console.WriteLine("courseTitle: " + r.courseTitle);
//                        Console.WriteLine("sectionRefId: " + r.sectionRefId);
//                        Console.WriteLine("subject: " + r.subject);
//                        Console.WriteLine("schoolRefId: " + r.schoolRefId);
//                        Console.WriteLine("schoolSectionId: " + r.schoolSectionId);
//                        Console.WriteLine("schoolYear: " + r.schoolYear);
//                        Console.WriteLine("sessionCode: " + r.sessionCode);
//                        Console.WriteLine("schoolCalendarRefId: " + r.schoolCalendarRefId);

//                        Console.WriteLine("##### BEGIN MEETING TIMES #####");
//                        foreach (XMeetingTimeType mt in r.meetingTimes.meetingTime)
//                        {
//                            Console.WriteLine("timeTableDay: " + mt.timeTableDay);

//                            Console.WriteLine("bellScheduleDay: " + mt.classMeetingDays.bellScheduleDay);
//                            Console.WriteLine("timeTablePeriod: " + mt.timeTablePeriod);
//                            Console.WriteLine("roomNumber: " + mt.roomNumber);
//                            Console.WriteLine("classBeginningTime: " + mt.classBeginningTime);
//                            Console.WriteLine("classEndingTime: " + mt.classEndingTime);
//                            Console.WriteLine("sessionCode: " + mt.sessionCode);
//                            Console.WriteLine("schoolCalendarRefId: " + mt.schoolCalendarRefId);
//                        }
//                        Console.WriteLine("##### END MEETING TIMES #####");
//                    }
//                }
//            }

//            Console.Read();
//        }
//    }
//}
