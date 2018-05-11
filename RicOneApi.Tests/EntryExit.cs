//using RicOneApi.Api;
//using RicOneApi.Models.Authentication;
//using RicOneApi.Models.XPress;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RicOneApi.Tests
//{
//    class EntryExit
//    {
//        static string authUrl = "https://auth.test.ricone.org/login";
//        static string clientId = "dpaDemo";
//        static string clientSecret = "deecd889bff5ed0101a86680752f5f9";
//        static string providerId = "localhost";

//        static void Main(string[] args)
//        {
//            Authenticator auth = Authenticator.Instance;
//            auth.Authenticate(authUrl, clientId, clientSecret);

//            foreach(Endpoint e in auth.GetEndpoints(providerId))
//            {
//                XPress xPress = new XPress(e.href);

//                if(xPress.GetXStudentsByXLea("15077B52-7D2A-4855-B41F-37FBA242522E").Data != null)
//			    {
//				    foreach(XStudentType s in xPress.GetXStudentsByXLea("15077B52-7D2A-4855-B41F-37FBA242522E").Data)
//				    {
//					    Console.WriteLine("refId: " + s.refId);
//					    Console.WriteLine("##### BEGIN ENROLLMENT #####");
//					    Console.WriteLine("leaRefId: " + s.enrollment.leaRefId);
//					    Console.WriteLine("schoolRefId: " + s.enrollment.schoolRefId);
//					    Console.WriteLine("membershipType: " + s.enrollment.membershipType);
//					    Console.WriteLine("entryDate: " + s.enrollment.entryDate);
//					    Console.WriteLine("##### BEGIN ENTRY TYPE #####");
//					    Console.WriteLine("ENTRY TYPE CODE: " + s.enrollment.entryType.code);
//					    foreach(XOtherCodeType oct in s.enrollment.entryType.otherCode)
//					    {
//						    Console.WriteLine("OTHER ENTRY TYPE CODENAME: " + oct.codesetName);
//						    Console.WriteLine("OTHER ENTRY TYPE CODE: " + oct.otherCodeValue);
//					    }
//					    Console.WriteLine("##### END ENTRY TYPE #####");
//					    Console.WriteLine("exitDate: " + s.enrollment.exitDate);
//					    Console.WriteLine("##### BEGIN EXIT TYPE #####");
//					    Console.WriteLine("EXIT TYPE CODE: " + s.enrollment.exitType.code);
//					    foreach(XOtherCodeType oct in s.enrollment.exitType.otherCode)
//					    {
//						    Console.WriteLine("OTHER EXIT TYPE CODENAME: " + oct.codesetName);
//						    Console.WriteLine("OTHER EXIT TYPE CODE: " + oct.otherCodeValue);
//					    }
//					    Console.WriteLine("##### END EXIT TYPE #####");
//					    Console.WriteLine("========================================");
//				    }
//			    }
//            }

//            Console.ReadLine();
//        }
//    }
//}
